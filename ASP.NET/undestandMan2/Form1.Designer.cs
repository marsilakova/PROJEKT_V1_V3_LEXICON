namespace understandHangman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGissa = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblSlutResultat = new System.Windows.Forms.Label();
            this.lblShowLetters = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGuessTheWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGissaHelaOrdet = new System.Windows.Forms.Button();
            this.txtTheWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNyttOrd = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nySpel = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGissa
            // 
            this.btnGissa.Location = new System.Drawing.Point(913, 280);
            this.btnGissa.Name = "btnGissa";
            this.btnGissa.Size = new System.Drawing.Size(132, 42);
            this.btnGissa.TabIndex = 0;
            this.btnGissa.Text = "Gissa";
            this.btnGissa.UseVisualStyleBackColor = true;
            this.btnGissa.Click += new System.EventHandler(this.btnGissa_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(913, 240);
            this.txtGuess.MaxLength = 1;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(247, 20);
            this.txtGuess.TabIndex = 1;
            // 
            // lblSlutResultat
            // 
            this.lblSlutResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSlutResultat.Location = new System.Drawing.Point(787, 114);
            this.lblSlutResultat.Name = "lblSlutResultat";
            this.lblSlutResultat.Size = new System.Drawing.Size(473, 35);
            this.lblSlutResultat.TabIndex = 2;
            // 
            // lblShowLetters
            // 
            this.lblShowLetters.Location = new System.Drawing.Point(910, 161);
            this.lblShowLetters.Name = "lblShowLetters";
            this.lblShowLetters.Size = new System.Drawing.Size(246, 32);
            this.lblShowLetters.TabIndex = 4;
            this.lblShowLetters.Text = "Bokstäver i ordet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gissa hela ordet:";
            // 
            // txtGuessTheWord
            // 
            this.txtGuessTheWord.AllowDrop = true;
            this.txtGuessTheWord.Location = new System.Drawing.Point(659, 240);
            this.txtGuessTheWord.Name = "txtGuessTheWord";
            this.txtGuessTheWord.Size = new System.Drawing.Size(200, 20);
            this.txtGuessTheWord.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(910, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Skriv bokstav:";
            // 
            // btnGissaHelaOrdet
            // 
            this.btnGissaHelaOrdet.Location = new System.Drawing.Point(659, 280);
            this.btnGissaHelaOrdet.Name = "btnGissaHelaOrdet";
            this.btnGissaHelaOrdet.Size = new System.Drawing.Size(132, 42);
            this.btnGissaHelaOrdet.TabIndex = 8;
            this.btnGissaHelaOrdet.Text = "Gissa hela ordet";
            this.btnGissaHelaOrdet.UseVisualStyleBackColor = true;
            this.btnGissaHelaOrdet.Click += new System.EventHandler(this.btnGissaHelaOrdet_Click);
            // 
            // txtTheWord
            // 
            this.txtTheWord.Location = new System.Drawing.Point(659, 361);
            this.txtTheWord.Name = "txtTheWord";
            this.txtTheWord.Size = new System.Drawing.Size(184, 20);
            this.txtTheWord.TabIndex = 9;
            this.txtTheWord.TextChanged += new System.EventHandler(this.txtTheWord_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(714, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // btnNyttOrd
            // 
            this.btnNyttOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNyttOrd.Location = new System.Drawing.Point(913, 357);
            this.btnNyttOrd.Name = "btnNyttOrd";
            this.btnNyttOrd.Size = new System.Drawing.Size(132, 42);
            this.btnNyttOrd.TabIndex = 11;
            this.btnNyttOrd.Text = "Skapa ord";
            this.btnNyttOrd.UseVisualStyleBackColor = true;
            this.btnNyttOrd.Click += new System.EventHandler(this.btnNyttOrd_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(468, 389);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 34);
            this.btnGo.TabIndex = 15;
            this.btnGo.Text = "button1";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Visible = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(784, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Välja ett av dem 2 språk :";
            // 
            // nySpel
            // 
            this.nySpel.AutoEllipsis = true;
            this.nySpel.BackgroundImage = global::understandHangman.Properties.Resources.images;
            this.nySpel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nySpel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nySpel.Image = global::understandHangman.Properties.Resources.images;
            this.nySpel.Location = new System.Drawing.Point(1108, 280);
            this.nySpel.Name = "nySpel";
            this.nySpel.Size = new System.Drawing.Size(179, 129);
            this.nySpel.TabIndex = 14;
            this.nySpel.Text = "Nytt  spel!!!";
            this.nySpel.UseVisualStyleBackColor = true;
            this.nySpel.Click += new System.EventHandler(this.nySpel_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.BackColor = System.Drawing.Color.Red;
            this.radioButton2.BackgroundImage = global::understandHangman.Properties.Resources.rysk;
            this.radioButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButton2.Location = new System.Drawing.Point(936, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(135, 65);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ryska";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.White;
            this.radioButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton1.BackgroundImage")));
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Gold;
            this.radioButton1.Location = new System.Drawing.Point(787, 47);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(123, 65);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Svenska";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::understandHangman.Properties.Resources.Galge;
            this.pictureBox1.Location = new System.Drawing.Point(56, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 281);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1350, 445);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.nySpel);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnNyttOrd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTheWord);
            this.Controls.Add(this.btnGissaHelaOrdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGuessTheWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblShowLetters);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSlutResultat);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.btnGissa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGissa;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblSlutResultat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblShowLetters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGuessTheWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGissaHelaOrdet;
        private System.Windows.Forms.TextBox txtTheWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNyttOrd;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button nySpel;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label4;
    }
}

