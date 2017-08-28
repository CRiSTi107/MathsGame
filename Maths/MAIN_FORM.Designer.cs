namespace Maths
{
    partial class MAIN_FORM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN_FORM));
            this.lbl_Question = new System.Windows.Forms.Label();
            this.btn_Ans_1 = new System.Windows.Forms.Button();
            this.btn_Ans_2 = new System.Windows.Forms.Button();
            this.btn_Ans_3 = new System.Windows.Forms.Button();
            this.btn_Ans_4 = new System.Windows.Forms.Button();
            this.border_down = new System.Windows.Forms.PictureBox();
            this.border_up = new System.Windows.Forms.PictureBox();
            this.border_right = new System.Windows.Forms.PictureBox();
            this.border_left = new System.Windows.Forms.PictureBox();
            this.panel_Question = new System.Windows.Forms.Panel();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lbl_Lifes = new System.Windows.Forms.Label();
            this.lbl_Seconds = new System.Windows.Forms.Label();
            this.panel_Answers = new System.Windows.Forms.Panel();
            this.tmr_Generate_Question = new System.Windows.Forms.Timer(this.components);
            this.panel_MainMenu = new System.Windows.Forms.Panel();
            this.linkLbl_DevelopedByCRiSTi = new System.Windows.Forms.LinkLabel();
            this.pic_logo_game = new System.Windows.Forms.PictureBox();
            this.lbl_Play = new System.Windows.Forms.Label();
            this.pic_border_right = new System.Windows.Forms.PictureBox();
            this.pic_border_left = new System.Windows.Forms.PictureBox();
            this.pic_border_down = new System.Windows.Forms.PictureBox();
            this.pic_border_up = new System.Windows.Forms.PictureBox();
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.lbl_HighScore = new System.Windows.Forms.Label();
            this.lbl_ResetHighScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.border_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.border_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.border_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.border_left)).BeginInit();
            this.panel_Question.SuspendLayout();
            this.panel_Answers.SuspendLayout();
            this.panel_MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_game)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_border_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_border_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_border_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_border_up)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Question
            // 
            this.lbl_Question.BackColor = System.Drawing.Color.Green;
            this.lbl_Question.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Question.ForeColor = System.Drawing.Color.White;
            this.lbl_Question.Location = new System.Drawing.Point(0, 0);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(460, 106);
            this.lbl_Question.TabIndex = 0;
            this.lbl_Question.Text = "00 + 00 = ??";
            this.lbl_Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Ans_1
            // 
            this.btn_Ans_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ans_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ans_1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Ans_1.Location = new System.Drawing.Point(0, 0);
            this.btn_Ans_1.Name = "btn_Ans_1";
            this.btn_Ans_1.Size = new System.Drawing.Size(198, 51);
            this.btn_Ans_1.TabIndex = 1;
            this.btn_Ans_1.Text = "{Answer_1}";
            this.btn_Ans_1.UseVisualStyleBackColor = true;
            this.btn_Ans_1.Click += new System.EventHandler(this.btn_Answers_Click);
            // 
            // btn_Ans_2
            // 
            this.btn_Ans_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ans_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ans_2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Ans_2.Location = new System.Drawing.Point(0, 73);
            this.btn_Ans_2.Name = "btn_Ans_2";
            this.btn_Ans_2.Size = new System.Drawing.Size(198, 51);
            this.btn_Ans_2.TabIndex = 2;
            this.btn_Ans_2.Text = "{Answer_2}";
            this.btn_Ans_2.UseVisualStyleBackColor = true;
            this.btn_Ans_2.Click += new System.EventHandler(this.btn_Answers_Click);
            // 
            // btn_Ans_3
            // 
            this.btn_Ans_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ans_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ans_3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Ans_3.Location = new System.Drawing.Point(262, 73);
            this.btn_Ans_3.Name = "btn_Ans_3";
            this.btn_Ans_3.Size = new System.Drawing.Size(198, 51);
            this.btn_Ans_3.TabIndex = 3;
            this.btn_Ans_3.Text = "{Answer_3}";
            this.btn_Ans_3.UseVisualStyleBackColor = true;
            this.btn_Ans_3.Click += new System.EventHandler(this.btn_Answers_Click);
            // 
            // btn_Ans_4
            // 
            this.btn_Ans_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ans_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ans_4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Ans_4.Location = new System.Drawing.Point(262, 0);
            this.btn_Ans_4.Name = "btn_Ans_4";
            this.btn_Ans_4.Size = new System.Drawing.Size(198, 51);
            this.btn_Ans_4.TabIndex = 4;
            this.btn_Ans_4.Text = "{Answer_4}";
            this.btn_Ans_4.UseVisualStyleBackColor = true;
            this.btn_Ans_4.Click += new System.EventHandler(this.btn_Answers_Click);
            // 
            // border_down
            // 
            this.border_down.BackColor = System.Drawing.Color.Peru;
            this.border_down.Location = new System.Drawing.Point(0, 96);
            this.border_down.Name = "border_down";
            this.border_down.Size = new System.Drawing.Size(450, 10);
            this.border_down.TabIndex = 5;
            this.border_down.TabStop = false;
            // 
            // border_up
            // 
            this.border_up.BackColor = System.Drawing.Color.Peru;
            this.border_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.border_up.Location = new System.Drawing.Point(0, 0);
            this.border_up.Name = "border_up";
            this.border_up.Size = new System.Drawing.Size(460, 10);
            this.border_up.TabIndex = 6;
            this.border_up.TabStop = false;
            // 
            // border_right
            // 
            this.border_right.BackColor = System.Drawing.Color.Peru;
            this.border_right.Location = new System.Drawing.Point(450, 10);
            this.border_right.Name = "border_right";
            this.border_right.Size = new System.Drawing.Size(10, 96);
            this.border_right.TabIndex = 7;
            this.border_right.TabStop = false;
            // 
            // border_left
            // 
            this.border_left.BackColor = System.Drawing.Color.Peru;
            this.border_left.Location = new System.Drawing.Point(0, 10);
            this.border_left.Name = "border_left";
            this.border_left.Size = new System.Drawing.Size(10, 86);
            this.border_left.TabIndex = 8;
            this.border_left.TabStop = false;
            // 
            // panel_Question
            // 
            this.panel_Question.Controls.Add(this.lbl_Score);
            this.panel_Question.Controls.Add(this.lbl_Lifes);
            this.panel_Question.Controls.Add(this.lbl_Seconds);
            this.panel_Question.Controls.Add(this.border_left);
            this.panel_Question.Controls.Add(this.border_down);
            this.panel_Question.Controls.Add(this.border_right);
            this.panel_Question.Controls.Add(this.border_up);
            this.panel_Question.Controls.Add(this.lbl_Question);
            this.panel_Question.Location = new System.Drawing.Point(738, 641);
            this.panel_Question.Name = "panel_Question";
            this.panel_Question.Size = new System.Drawing.Size(460, 212);
            this.panel_Question.TabIndex = 10;
            // 
            // lbl_Score
            // 
            this.lbl_Score.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Score.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Score.Location = new System.Drawing.Point(3, 175);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(454, 34);
            this.lbl_Score.TabIndex = 11;
            this.lbl_Score.Text = "Score";
            this.lbl_Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Lifes
            // 
            this.lbl_Lifes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Lifes.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Lifes.Location = new System.Drawing.Point(3, 141);
            this.lbl_Lifes.Name = "lbl_Lifes";
            this.lbl_Lifes.Size = new System.Drawing.Size(454, 34);
            this.lbl_Lifes.TabIndex = 10;
            this.lbl_Lifes.Text = "Lifes";
            this.lbl_Lifes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Lifes.TextChanged += new System.EventHandler(this.lbl_Lifes_TextChanged);
            // 
            // lbl_Seconds
            // 
            this.lbl_Seconds.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Seconds.ForeColor = System.Drawing.Color.Black;
            this.lbl_Seconds.Location = new System.Drawing.Point(3, 109);
            this.lbl_Seconds.Name = "lbl_Seconds";
            this.lbl_Seconds.Size = new System.Drawing.Size(454, 34);
            this.lbl_Seconds.TabIndex = 9;
            this.lbl_Seconds.Text = "Seconds left ";
            this.lbl_Seconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Answers
            // 
            this.panel_Answers.Controls.Add(this.btn_Ans_4);
            this.panel_Answers.Controls.Add(this.btn_Ans_1);
            this.panel_Answers.Controls.Add(this.btn_Ans_3);
            this.panel_Answers.Controls.Add(this.btn_Ans_2);
            this.panel_Answers.Location = new System.Drawing.Point(561, 464);
            this.panel_Answers.Name = "panel_Answers";
            this.panel_Answers.Size = new System.Drawing.Size(460, 124);
            this.panel_Answers.TabIndex = 11;
            // 
            // tmr_Generate_Question
            // 
            this.tmr_Generate_Question.Interval = 1000;
            this.tmr_Generate_Question.Tick += new System.EventHandler(this.tmr_Generate_Question_Tick);
            // 
            // panel_MainMenu
            // 
            this.panel_MainMenu.BackColor = System.Drawing.Color.Green;
            this.panel_MainMenu.Controls.Add(this.lbl_ResetHighScore);
            this.panel_MainMenu.Controls.Add(this.linkLbl_DevelopedByCRiSTi);
            this.panel_MainMenu.Controls.Add(this.pic_logo_game);
            this.panel_MainMenu.Controls.Add(this.lbl_Play);
            this.panel_MainMenu.Controls.Add(this.pic_border_right);
            this.panel_MainMenu.Controls.Add(this.pic_border_left);
            this.panel_MainMenu.Controls.Add(this.pic_border_down);
            this.panel_MainMenu.Controls.Add(this.pic_border_up);
            this.panel_MainMenu.Controls.Add(this.lbl_Exit);
            this.panel_MainMenu.Controls.Add(this.lbl_HighScore);
            this.panel_MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MainMenu.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.panel_MainMenu.Name = "panel_MainMenu";
            this.panel_MainMenu.Size = new System.Drawing.Size(484, 400);
            this.panel_MainMenu.TabIndex = 12;
            // 
            // linkLbl_DevelopedByCRiSTi
            // 
            this.linkLbl_DevelopedByCRiSTi.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLbl_DevelopedByCRiSTi.AutoSize = true;
            this.linkLbl_DevelopedByCRiSTi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLbl_DevelopedByCRiSTi.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.linkLbl_DevelopedByCRiSTi.Location = new System.Drawing.Point(275, 368);
            this.linkLbl_DevelopedByCRiSTi.Name = "linkLbl_DevelopedByCRiSTi";
            this.linkLbl_DevelopedByCRiSTi.Size = new System.Drawing.Size(197, 19);
            this.linkLbl_DevelopedByCRiSTi.TabIndex = 7;
            this.linkLbl_DevelopedByCRiSTi.TabStop = true;
            this.linkLbl_DevelopedByCRiSTi.Text = "Developed by CRiSTi( ͡° ͜ʖ ͡°)";
            this.linkLbl_DevelopedByCRiSTi.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(225)))));
            this.linkLbl_DevelopedByCRiSTi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_DevelopedByCRiSTi_LinkClicked);
            // 
            // pic_logo_game
            // 
            this.pic_logo_game.BackgroundImage = global::Maths.Properties.Resources.logo_maths_game;
            this.pic_logo_game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_logo_game.Location = new System.Drawing.Point(12, 12);
            this.pic_logo_game.Name = "pic_logo_game";
            this.pic_logo_game.Size = new System.Drawing.Size(460, 76);
            this.pic_logo_game.TabIndex = 6;
            this.pic_logo_game.TabStop = false;
            // 
            // lbl_Play
            // 
            this.lbl_Play.AutoSize = true;
            this.lbl_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Play.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Play.ForeColor = System.Drawing.Color.Black;
            this.lbl_Play.Location = new System.Drawing.Point(196, 175);
            this.lbl_Play.Name = "lbl_Play";
            this.lbl_Play.Size = new System.Drawing.Size(70, 37);
            this.lbl_Play.TabIndex = 5;
            this.lbl_Play.Text = "&Play";
            this.lbl_Play.Click += new System.EventHandler(this.lbl_Play_Click);
            this.lbl_Play.MouseEnter += new System.EventHandler(this.lbl_Main_MouseEnter);
            this.lbl_Play.MouseLeave += new System.EventHandler(this.lbl_Main_MouseLeave);
            // 
            // pic_border_right
            // 
            this.pic_border_right.BackColor = System.Drawing.Color.Peru;
            this.pic_border_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_border_right.Location = new System.Drawing.Point(474, 10);
            this.pic_border_right.Name = "pic_border_right";
            this.pic_border_right.Size = new System.Drawing.Size(10, 380);
            this.pic_border_right.TabIndex = 4;
            this.pic_border_right.TabStop = false;
            // 
            // pic_border_left
            // 
            this.pic_border_left.BackColor = System.Drawing.Color.Peru;
            this.pic_border_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_border_left.Location = new System.Drawing.Point(0, 10);
            this.pic_border_left.Name = "pic_border_left";
            this.pic_border_left.Size = new System.Drawing.Size(10, 380);
            this.pic_border_left.TabIndex = 3;
            this.pic_border_left.TabStop = false;
            // 
            // pic_border_down
            // 
            this.pic_border_down.BackColor = System.Drawing.Color.Peru;
            this.pic_border_down.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pic_border_down.Location = new System.Drawing.Point(0, 390);
            this.pic_border_down.Name = "pic_border_down";
            this.pic_border_down.Size = new System.Drawing.Size(484, 10);
            this.pic_border_down.TabIndex = 2;
            this.pic_border_down.TabStop = false;
            // 
            // pic_border_up
            // 
            this.pic_border_up.BackColor = System.Drawing.Color.Peru;
            this.pic_border_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_border_up.Location = new System.Drawing.Point(0, 0);
            this.pic_border_up.Name = "pic_border_up";
            this.pic_border_up.Size = new System.Drawing.Size(484, 10);
            this.pic_border_up.TabIndex = 1;
            this.pic_border_up.TabStop = false;
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.AutoSize = true;
            this.lbl_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Exit.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Exit.ForeColor = System.Drawing.Color.Black;
            this.lbl_Exit.Location = new System.Drawing.Point(201, 280);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(65, 37);
            this.lbl_Exit.TabIndex = 0;
            this.lbl_Exit.Text = "&Exit";
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            this.lbl_Exit.MouseEnter += new System.EventHandler(this.lbl_Main_MouseEnter);
            this.lbl_Exit.MouseLeave += new System.EventHandler(this.lbl_Main_MouseLeave);
            // 
            // lbl_HighScore
            // 
            this.lbl_HighScore.AutoSize = true;
            this.lbl_HighScore.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_HighScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_HighScore.ForeColor = System.Drawing.Color.Black;
            this.lbl_HighScore.Location = new System.Drawing.Point(12, 365);
            this.lbl_HighScore.Name = "lbl_HighScore";
            this.lbl_HighScore.Size = new System.Drawing.Size(153, 21);
            this.lbl_HighScore.TabIndex = 8;
            this.lbl_HighScore.Text = "Your high score is: ";
            // 
            // lbl_ResetHighScore
            // 
            this.lbl_ResetHighScore.AutoSize = true;
            this.lbl_ResetHighScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ResetHighScore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_ResetHighScore.Location = new System.Drawing.Point(13, 348);
            this.lbl_ResetHighScore.Name = "lbl_ResetHighScore";
            this.lbl_ResetHighScore.Size = new System.Drawing.Size(108, 17);
            this.lbl_ResetHighScore.TabIndex = 9;
            this.lbl_ResetHighScore.Text = "Reset High Score";
            this.lbl_ResetHighScore.Click += new System.EventHandler(this.lbl_ResetHighScore_Click);
            // 
            // MAIN_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 400);
            this.Controls.Add(this.panel_Question);
            this.Controls.Add(this.panel_Answers);
            this.Controls.Add(this.panel_MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 438);
            this.Name = "MAIN_FORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maths Game - Developed by CRiSTi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MAIN_FORM_FormClosing);
            this.Load += new System.EventHandler(this.MAIN_FORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.border_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.border_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.border_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.border_left)).EndInit();
            this.panel_Question.ResumeLayout(false);
            this.panel_Answers.ResumeLayout(false);
            this.panel_MainMenu.ResumeLayout(false);
            this.panel_MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_game)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_border_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_border_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_border_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_border_up)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.Button btn_Ans_1;
        private System.Windows.Forms.Button btn_Ans_2;
        private System.Windows.Forms.Button btn_Ans_3;
        private System.Windows.Forms.Button btn_Ans_4;
        private System.Windows.Forms.PictureBox border_down;
        private System.Windows.Forms.PictureBox border_up;
        private System.Windows.Forms.PictureBox border_right;
        private System.Windows.Forms.PictureBox border_left;
        private System.Windows.Forms.Panel panel_Question;
        private System.Windows.Forms.Panel panel_Answers;
        private System.Windows.Forms.Timer tmr_Generate_Question;
        private System.Windows.Forms.Panel panel_MainMenu;
        private System.Windows.Forms.PictureBox pic_border_right;
        private System.Windows.Forms.PictureBox pic_border_left;
        private System.Windows.Forms.PictureBox pic_border_down;
        private System.Windows.Forms.PictureBox pic_border_up;
        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.Label lbl_Play;
        private System.Windows.Forms.PictureBox pic_logo_game;
        private System.Windows.Forms.LinkLabel linkLbl_DevelopedByCRiSTi;
        private System.Windows.Forms.Label lbl_HighScore;
        private System.Windows.Forms.Label lbl_Seconds;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label lbl_Lifes;
        private System.Windows.Forms.Label lbl_ResetHighScore;
    }
}

