namespace GuessTheNumber
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtplayernum = new System.Windows.Forms.TextBox();
            this.lblai = new System.Windows.Forms.Label();
            this.lbAiSpeech = new System.Windows.Forms.Label();
            this.lblplayer = new System.Windows.Forms.Label();
            this.btnbigger = new System.Windows.Forms.Button();
            this.btnsmaller = new System.Windows.Forms.Button();
            this.btnrightnumber = new System.Windows.Forms.Button();
            this.btncheck = new System.Windows.Forms.Button();
            this.lblAiQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(354, 197);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(116, 41);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtplayernum
            // 
            this.txtplayernum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplayernum.Location = new System.Drawing.Point(382, 72);
            this.txtplayernum.Name = "txtplayernum";
            this.txtplayernum.Size = new System.Drawing.Size(88, 26);
            this.txtplayernum.TabIndex = 1;
            // 
            // lblai
            // 
            this.lblai.AutoSize = true;
            this.lblai.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblai.Location = new System.Drawing.Point(36, 10);
            this.lblai.Name = "lblai";
            this.lblai.Size = new System.Drawing.Size(42, 31);
            this.lblai.TabIndex = 2;
            this.lblai.Text = "AI";
            // 
            // lbAiSpeech
            // 
            this.lbAiSpeech.AutoSize = true;
            this.lbAiSpeech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAiSpeech.Location = new System.Drawing.Point(12, 55);
            this.lbAiSpeech.Name = "lbAiSpeech";
            this.lbAiSpeech.Size = new System.Drawing.Size(0, 20);
            this.lbAiSpeech.TabIndex = 2;
            // 
            // lblplayer
            // 
            this.lblplayer.AutoSize = true;
            this.lblplayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblplayer.Location = new System.Drawing.Point(353, 10);
            this.lblplayer.Name = "lblplayer";
            this.lblplayer.Size = new System.Drawing.Size(94, 31);
            this.lblplayer.TabIndex = 2;
            this.lblplayer.Text = "player";
            // 
            // btnbigger
            // 
            this.btnbigger.Location = new System.Drawing.Point(12, 131);
            this.btnbigger.Name = "btnbigger";
            this.btnbigger.Size = new System.Drawing.Size(74, 42);
            this.btnbigger.TabIndex = 0;
            this.btnbigger.Text = "Bigger";
            this.btnbigger.UseVisualStyleBackColor = true;
            this.btnbigger.Click += new System.EventHandler(this.btnbigger_Click);
            // 
            // btnsmaller
            // 
            this.btnsmaller.Location = new System.Drawing.Point(92, 131);
            this.btnsmaller.Name = "btnsmaller";
            this.btnsmaller.Size = new System.Drawing.Size(74, 42);
            this.btnsmaller.TabIndex = 0;
            this.btnsmaller.Text = "SMALLER";
            this.btnsmaller.UseVisualStyleBackColor = true;
            this.btnsmaller.Click += new System.EventHandler(this.btnsmaller_Click);
            // 
            // btnrightnumber
            // 
            this.btnrightnumber.Location = new System.Drawing.Point(172, 131);
            this.btnrightnumber.Name = "btnrightnumber";
            this.btnrightnumber.Size = new System.Drawing.Size(75, 42);
            this.btnrightnumber.TabIndex = 0;
            this.btnrightnumber.Text = "Right Number";
            this.btnrightnumber.UseVisualStyleBackColor = true;
            this.btnrightnumber.Click += new System.EventHandler(this.btnrightnumber_Click);
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(395, 131);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(75, 42);
            this.btncheck.TabIndex = 3;
            this.btncheck.Text = "Check";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // lblAiQuestion
            // 
            this.lblAiQuestion.AutoSize = true;
            this.lblAiQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAiQuestion.Location = new System.Drawing.Point(12, 88);
            this.lblAiQuestion.Name = "lblAiQuestion";
            this.lblAiQuestion.Size = new System.Drawing.Size(0, 20);
            this.lblAiQuestion.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 256);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.lblAiQuestion);
            this.Controls.Add(this.lbAiSpeech);
            this.Controls.Add(this.lblplayer);
            this.Controls.Add(this.lblai);
            this.Controls.Add(this.txtplayernum);
            this.Controls.Add(this.btnsmaller);
            this.Controls.Add(this.btnbigger);
            this.Controls.Add(this.btnrightnumber);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Guess The Number";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtplayernum;
        private System.Windows.Forms.Label lblai;
        private System.Windows.Forms.Label lbAiSpeech;
        private System.Windows.Forms.Label lblplayer;
        private System.Windows.Forms.Button btnbigger;
        private System.Windows.Forms.Button btnsmaller;
        private System.Windows.Forms.Button btnrightnumber;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Label lblAiQuestion;
    }
}

