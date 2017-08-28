using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Maths
{
    public partial class MAIN_FORM : Form
    {
        public MAIN_FORM()
        {
            InitializeComponent();

            lst_btns.Add(btn_Ans_1); lst_btns.Add(btn_Ans_2); lst_btns.Add(btn_Ans_3); lst_btns.Add(btn_Ans_4);
            this.BackColor = clr_Control;
            this.Size = new Size(500, 438);


            tmr_wait.Tick += new EventHandler(tmr_wait_Tick);


        }
        private Timer tmr_wait = new Timer() { Enabled = false, Interval = 1000 };
        private void tmr_wait_Tick(object sender, EventArgs e)
        {
            lbl_Seconds.Text = "Seconds left 5";
            Generate_Question();
            tmr_wait.Stop();
            tmr_Generate_Question.Start();
        }
        private void MAIN_FORM_Load(object sender, EventArgs e)
        {
            tmr_Generate_Question.Stop();

            Generate_Question();

            lbl_Play.Location = new Point(this.Size.Width / 2 - lbl_Play.Size.Width / 2 - 20, 175);
            lbl_Exit.Location = new Point(this.Size.Width / 2 - lbl_Exit.Size.Width / 2 - 20, 280);


            lbl_HighScore.Text = "Your high score is: " + getHighScore().ToString();

            //lbl_HighScore.Location = new Point(this.Size.Width / 2 - lbl_HighScore.Size.Width / 2 - 20, lbl_HighScore.Location.Y);

            //panel_Answers.Location = new Point(12, 264);
            //panel_Question.Location = new Point(12, 9);

            panel_Answers.Hide();
            panel_Answers.Enabled = false;


            panel_Question.Hide();
            panel_Question.Enabled = false;



            //this.lbl_Logo.Font = new System.Drawing.Font("Drawing Guides", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));


            


        }

        private Color clr_Control = Color.FromArgb(223, 223, 223);


        private List<Button> lst_btns = new List<Button>();

        private Random Randomizer = new Random();

        private float Question_Arg1;
        private char Question_Sign;
        private float Question_Arg2;
        private float Correct_Answer;

        private bool Answered = false;

        private int getHighScore()
        {
            try
            {
                File.SetAttributes("highscore", FileAttributes.Hidden);
                using (System.IO.StreamReader FILE = new System.IO.StreamReader("highscore"))
                {
                    File.SetAttributes("highscore", FileAttributes.Hidden | FileAttributes.System | FileAttributes.ReadOnly);
                    return Convert.ToInt32(FILE.ReadLine());
                }
            }
            catch
            {
                if (!File.Exists("highscore"))
                {
                    MessageBox.Show("High score file cannot be found!" + "The program will create a new one.", "Error loading highscore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    StreamWriter FILE = new StreamWriter("highscore", false, Encoding.UTF8);
                    FILE.Write("0");
                    FILE.Close();

                    File.SetAttributes("highscore", FileAttributes.Hidden | FileAttributes.System  | FileAttributes.ReadOnly);
                }
                return 0;
            }
        }


        protected virtual bool IsFileinUse(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException )
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
        }

        public void Generate_Question()
        {
            Answered = false;
            lbl_Seconds.Text = "Seconds left 5";
            lbl_Score.Text = "Score " + Convert.ToString(Score);
            lbl_Lifes.Text = "Lifes " + Convert.ToString(Lifes);


            foreach(Button btn in lst_btns)
            {
                btn.Enabled = true;
                btn.BackColor = clr_Control;
            }


            Question_Arg1 = Randomizer.Next(1, 50);
            Question_Arg2 = Randomizer.Next(1, 50);

            int q_sign = Randomizer.Next(1, 5); // 1 for + | 2 for - | 3 for * | 4 for /

            switch(q_sign)
            {
                case 1: Question_Sign = '+'; Correct_Answer = Question_Arg1 + Question_Arg2; break;
                case 2: Question_Sign = '-'; Correct_Answer = Question_Arg1 - Question_Arg2; break;
                case 3: Question_Sign = '*'; Correct_Answer = Question_Arg1 * Question_Arg2; break;
                case 4: Question_Sign = '/'; Correct_Answer = Question_Arg1 / Question_Arg2; Correct_Answer = (float)Convert.ToDecimal(Correct_Answer.ToString("0.00")); break;
            }

            int ans_pos = Randomizer.Next(1, 5);
            
            switch(ans_pos)
            {
                case 1: btn_Ans_1.Text = Correct_Answer.ToString();             btn_Ans_2.Text = Convert.ToString(Correct_Answer + 10);                                               btn_Ans_3.Text = Convert.ToString(Correct_Answer - 1);                        btn_Ans_4.Text = Convert.ToString(Math.Round((float)Correct_Answer / 2, 2, MidpointRounding.ToEven));   break;
                case 2: btn_Ans_1.Text = Convert.ToString(Correct_Answer - 10); btn_Ans_2.Text = Correct_Answer.ToString();                                                           btn_Ans_3.Text = Convert.ToString((int)(Question_Arg1/2) + Question_Arg2*2);  btn_Ans_4.Text = Convert.ToString(Correct_Answer + 1);                                                  break;
                case 3: btn_Ans_1.Text = Convert.ToString(Correct_Answer + 10); btn_Ans_2.Text = Convert.ToString(Correct_Answer + 1);                                                btn_Ans_3.Text = Correct_Answer.ToString();                                   btn_Ans_4.Text = Convert.ToString(Correct_Answer - 2);                                                  break;
                case 4: btn_Ans_1.Text = Convert.ToString(Correct_Answer + 1);  btn_Ans_2.Text = Convert.ToString(Math.Round((float)Correct_Answer / 2, 2, MidpointRounding.ToEven)); btn_Ans_3.Text = Convert.ToString(Correct_Answer - 1);                        btn_Ans_4.Text = Correct_Answer.ToString();                                                             break;
            }

            lbl_Question.Text = Question_Arg1.ToString() + " " + Question_Sign + " " + Question_Arg2.ToString() + " = ?";
            lbl_Seconds.Text = "Seconds left " + Convert.ToString(Math.Abs(generateSec - 4));
            
        }





        private int Lifes = 3, Score = 0;





        
        void wait1Second()
        {
            
            tmr_wait.Start();
        }

        private void btn_Answers_Click(object sender, EventArgs e)
        {
            Answered = true;

            foreach (Button btn in lst_btns)
                btn.Enabled = false;

            Button btn_Ans = (Button)sender;

            if (btn_Ans.Text == Correct_Answer.ToString())
            {
                btn_Ans.BackColor = Color.Green; Score++;
            }
            else
            {
                btn_Ans.BackColor = Color.Red;
                Lifes--;
                foreach (Button btn in lst_btns)
                {
                    btn.Enabled = false;
                    if (btn.Text == Correct_Answer.ToString())
                        btn.BackColor = Color.Green;                       
                }
            }

            
            generateSec = 0;
            tmr_Generate_Question.Stop();
            wait1Second();

            lbl_Score.Text = "Score " + Convert.ToString(Score);
            lbl_Lifes.Text = "Lifes " + Convert.ToString(Lifes);
            
        }


        private int generateSec = 0;

        private void tmr_Generate_Question_Tick(object sender, EventArgs e)
        {
            lbl_Seconds.Text = "Seconds left " + Convert.ToString(Math.Abs(generateSec-4));

            if (++generateSec == 5)
            {
                generateSec = 0;

                foreach (Button btn in lst_btns)
                {
                    btn.Enabled = false;
                    if (btn.Text == Convert.ToString(Correct_Answer))
                        btn.BackColor = Color.Yellow;
                }

                wait1Second();

                if (!Answered)
                { Lifes--; lbl_Lifes.Text = "Lifes " + Convert.ToString(Lifes); return; }

                Generate_Question();

                
            }

        }


        #region Desingn
        private void lbl_Main_MouseLeave(object sender, EventArgs e)
        {
            Label actual_btn = (Label)sender;
            actual_btn.ForeColor = Color.Black;
        }
        private void lbl_Main_MouseEnter(object sender, EventArgs e)
        {
            Label actual_btn = (Label)sender;
            actual_btn.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225);
        }
        #endregion

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Play_Click(object sender, EventArgs e)
        {
            Generate_Question();
            lbl_Seconds.Text = "Seconds left 5";

            Lifes = 3; generateSec = 0; Score = 0;

            Answered = false;
            lbl_Seconds.Text = "Seconds left 5";
            lbl_Score.Text = "Score " + Convert.ToString(Score);
            lbl_Lifes.Text = "Lifes " + Convert.ToString(Lifes);


            foreach (Button btn in lst_btns)
            {
                btn.Enabled = true;
                btn.BackColor = clr_Control;
            }

            panel_MainMenu.Hide();

            panel_Answers.Location = new Point(12, 264);
            panel_Question.Location = new Point(12, 9);

            panel_Answers.Show();
            panel_Answers.Enabled = true;


            panel_Question.Show();
            panel_Question.Enabled = true;

            tmr_Generate_Question.Start();

            
            

        }

        private static string  facebookID = "100004543157409";
        private void linkLbl_DevelopedByCRiSTi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=" + facebookID + "&fref=hovercard");}

        private void lbl_Lifes_TextChanged(object sender, EventArgs e)
        {
            if(Lifes == -1)
            {
                tmr_Generate_Question.Stop();
                
                panel_Answers.Hide();
                panel_Answers.Enabled = false;


                panel_Question.Hide();
                panel_Question.Enabled = false;

                if (Score > getHighScore())
                {
                    File.SetAttributes("highscore", FileAttributes.Hidden | FileAttributes.System | FileAttributes.ReadOnly);
                    try
                    {
                        if (File.Exists("highscore"))
                            File.SetAttributes("highscore", FileAttributes.Normal);

                        using (StreamWriter FILE = new StreamWriter("highscore"))
                        {
                            FILE.Write(Score.ToString());
                        }
                    }
                    catch { }
                    File.SetAttributes("highscore", FileAttributes.Hidden | FileAttributes.System | FileAttributes.ReadOnly);
                    lbl_HighScore.Text = "Your highscore is " + getHighScore();
                    
                    panel_MainMenu.Show();
                    msgNewHighScore(Score);
                    return;
                }
                panel_MainMenu.Show();
                msgYouLost(Score);
            }


        }

        void msgYouLost(int _Score)
        {
            MessageBox.Show("Your score  " + Convert.ToString(_Score), "You lost!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        void msgNewHighScore(int _Score)
        {
            MessageBox.Show("Your new high score is " + Convert.ToString(_Score), "New High Score!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MAIN_FORM_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.SetAttributes("highscore", FileAttributes.Hidden | FileAttributes.System | FileAttributes.ReadOnly);
        }

        private void lbl_ResetHighScore_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to reset the highscore?", "Maths Game", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                File.SetAttributes("highscore", FileAttributes.Normal);
                try
                {
                    StreamWriter FILE = new StreamWriter("highscore", false, Encoding.UTF8);
                    FILE.Write("0");
                    FILE.Close();

                    File.SetAttributes("highscore", FileAttributes.Hidden | FileAttributes.System | FileAttributes.ReadOnly);

                    lbl_HighScore.Text = "Your highscore is " + getHighScore();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
