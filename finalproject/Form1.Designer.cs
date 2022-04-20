
namespace finalproject
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
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShiftRight = new System.Windows.Forms.Button();
            this.btnShiftUp = new System.Windows.Forms.Button();
            this.btnShiftDown = new System.Windows.Forms.Button();
            this.btnShiftLeft = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblOneOne = new System.Windows.Forms.Label();
            this.lblOneTwo = new System.Windows.Forms.Label();
            this.lblOneThree = new System.Windows.Forms.Label();
            this.lblOneFour = new System.Windows.Forms.Label();
            this.lblTwoFour = new System.Windows.Forms.Label();
            this.lblTwoThree = new System.Windows.Forms.Label();
            this.lblTwoOne = new System.Windows.Forms.Label();
            this.lblTwoTwo = new System.Windows.Forms.Label();
            this.lblFourFour = new System.Windows.Forms.Label();
            this.lblFourThree = new System.Windows.Forms.Label();
            this.lblFourTwo = new System.Windows.Forms.Label();
            this.lblFourOne = new System.Windows.Forms.Label();
            this.lblThreeFour = new System.Windows.Forms.Label();
            this.lblThreeTwo = new System.Windows.Forms.Label();
            this.lblThreeThree = new System.Windows.Forms.Label();
            this.lblThreeOne = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox17
            // 
            this.textBox17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox17.Location = new System.Drawing.Point(754, 55);
            this.textBox17.Margin = new System.Windows.Forms.Padding(4);
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(132, 38);
            this.textBox17.TabIndex = 16;
            // 
            // lblScore
            // 
            this.lblScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(798, 34);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(45, 17);
            this.lblScore.TabIndex = 17;
            this.lblScore.Text = "Score";
            // 
            // textBox18
            // 
            this.textBox18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox18.Location = new System.Drawing.Point(99, 55);
            this.textBox18.Margin = new System.Windows.Forms.Padding(4);
            this.textBox18.Multiline = true;
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(132, 38);
            this.textBox18.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "High Score";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 41);
            this.button1.TabIndex = 20;
            this.button1.Text = "♻️";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Form1_Load);
            // 
            // btnShiftRight
            // 
            this.btnShiftRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShiftRight.BackColor = System.Drawing.Color.Gainsboro;
            this.btnShiftRight.Location = new System.Drawing.Point(935, 406);
            this.btnShiftRight.Name = "btnShiftRight";
            this.btnShiftRight.Size = new System.Drawing.Size(35, 360);
            this.btnShiftRight.TabIndex = 22;
            this.btnShiftRight.Text = "→";
            this.btnShiftRight.UseVisualStyleBackColor = false;
            this.btnShiftRight.Click += new System.EventHandler(this.btnShiftRight_Click);
            // 
            // btnShiftUp
            // 
            this.btnShiftUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShiftUp.BackColor = System.Drawing.Color.Gainsboro;
            this.btnShiftUp.Location = new System.Drawing.Point(319, 123);
            this.btnShiftUp.Name = "btnShiftUp";
            this.btnShiftUp.Size = new System.Drawing.Size(360, 35);
            this.btnShiftUp.TabIndex = 24;
            this.btnShiftUp.Text = "↑";
            this.btnShiftUp.UseVisualStyleBackColor = false;
            this.btnShiftUp.Click += new System.EventHandler(this.btnShiftUp_Click);
            // 
            // btnShiftDown
            // 
            this.btnShiftDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShiftDown.BackColor = System.Drawing.Color.Gainsboro;
            this.btnShiftDown.Location = new System.Drawing.Point(320, 1035);
            this.btnShiftDown.Name = "btnShiftDown";
            this.btnShiftDown.Size = new System.Drawing.Size(360, 35);
            this.btnShiftDown.TabIndex = 25;
            this.btnShiftDown.Text = "↓";
            this.btnShiftDown.UseVisualStyleBackColor = false;
            this.btnShiftDown.Click += new System.EventHandler(this.btnShiftDown_Click);
            // 
            // btnShiftLeft
            // 
            this.btnShiftLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShiftLeft.BackColor = System.Drawing.Color.Gainsboro;
            this.btnShiftLeft.Location = new System.Drawing.Point(22, 406);
            this.btnShiftLeft.Name = "btnShiftLeft";
            this.btnShiftLeft.Size = new System.Drawing.Size(35, 360);
            this.btnShiftLeft.TabIndex = 26;
            this.btnShiftLeft.Text = "←";
            this.btnShiftLeft.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.pictureBox1.Location = new System.Drawing.Point(56, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(882, 887);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(994, 1162);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // lblOneOne
            // 
            this.lblOneOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOneOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.lblOneOne.Font = new System.Drawing.Font("Clear Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneOne.Location = new System.Drawing.Point(80, 174);
            this.lblOneOne.Margin = new System.Windows.Forms.Padding(4);
            this.lblOneOne.Name = "lblOneOne";
            this.lblOneOne.Size = new System.Drawing.Size(190, 190);
            this.lblOneOne.TabIndex = 29;
            this.lblOneOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOneTwo
            // 
            this.lblOneTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOneTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.lblOneTwo.Font = new System.Drawing.Font("Clear Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneTwo.Location = new System.Drawing.Point(296, 174);
            this.lblOneTwo.Margin = new System.Windows.Forms.Padding(4);
            this.lblOneTwo.Name = "lblOneTwo";
            this.lblOneTwo.Size = new System.Drawing.Size(190, 190);
            this.lblOneTwo.TabIndex = 30;
            this.lblOneTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOneThree
            // 
            this.lblOneThree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOneThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.lblOneThree.Font = new System.Drawing.Font("Clear Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneThree.Location = new System.Drawing.Point(511, 174);
            this.lblOneThree.Margin = new System.Windows.Forms.Padding(4);
            this.lblOneThree.Name = "lblOneThree";
            this.lblOneThree.Size = new System.Drawing.Size(190, 190);
            this.lblOneThree.TabIndex = 31;
            this.lblOneThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOneFour
            // 
            this.lblOneFour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOneFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.lblOneFour.Font = new System.Drawing.Font("Clear Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneFour.Location = new System.Drawing.Point(722, 174);
            this.lblOneFour.Margin = new System.Windows.Forms.Padding(4);
            this.lblOneFour.Name = "lblOneFour";
            this.lblOneFour.Size = new System.Drawing.Size(190, 190);
            this.lblOneFour.TabIndex = 32;
            this.lblOneFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTwoFour
            // 
            this.lblTwoFour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTwoFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.lblTwoFour.Font = new System.Drawing.Font("Clear Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwoFour.Location = new System.Drawing.Point(722, 389);
            this.lblTwoFour.Margin = new System.Windows.Forms.Padding(4);
            this.lblTwoFour.Name = "lblTwoFour";
            this.lblTwoFour.Size = new System.Drawing.Size(190, 190);
            this.lblTwoFour.TabIndex = 36;
            this.lblTwoFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTwoThree
            // 
            this.lblTwoThree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTwoThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.lblTwoThree.Font = new System.Drawing.Font("Clear Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwoThree.Location = new System.Drawing.Point(511, 389);
            this.lblTwoThree.Margin = new System.Windows.Forms.Padding(4);
            this.lblTwoThree.Name = "lblTwoThree";
            this.lblTwoThree.Size = new System.Drawing.Size(190, 190);
            this.lblTwoThree.TabIndex = 35;
            this.lblTwoThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTwoOne
            // 
            this.lblTwoOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTwoOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.lblTwoOne.Font = new System.Drawing.Font("Clear Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwoOne.Location = new System.Drawing.Point(80, 389);
            this.lblTwoOne.Margin = new System.Windows.Forms.Padding(4);
            this.lblTwoOne.Name = "lblTwoOne";
            this.lblTwoOne.Size = new System.Drawing.Size(190, 190);
            this.lblTwoOne.TabIndex = 33;
            this.lblTwoOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTwoTwo
            // 
            this.lblTwoTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTwoTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.lblTwoTwo.Font = new System.Drawing.Font("Clear Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwoTwo.Location = new System.Drawing.Point(296, 389);
            this.lblTwoTwo.Margin = new System.Windows.Forms.Padding(4);
            this.lblTwoTwo.Name = "lblTwoTwo";
            this.lblTwoTwo.Size = new System.Drawing.Size(190, 190);
            this.lblTwoTwo.TabIndex = 34;
            this.lblTwoTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFourFour
            // 
            this.lblFourFour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFourFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.lblFourFour.Font = new System.Drawing.Font("Clear Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFourFour.Location = new System.Drawing.Point(722, 819);
            this.lblFourFour.Margin = new System.Windows.Forms.Padding(4);
            this.lblFourFour.Name = "lblFourFour";
            this.lblFourFour.Size = new System.Drawing.Size(190, 190);
            this.lblFourFour.TabIndex = 44;
            this.lblFourFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFourThree
            // 
            this.lblFourThree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFourThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.lblFourThree.Font = new System.Drawing.Font("Clear Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFourThree.Location = new System.Drawing.Point(511, 819);
            this.lblFourThree.Margin = new System.Windows.Forms.Padding(4);
            this.lblFourThree.Name = "lblFourThree";
            this.lblFourThree.Size = new System.Drawing.Size(190, 190);
            this.lblFourThree.TabIndex = 43;
            this.lblFourThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFourTwo
            // 
            this.lblFourTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFourTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.lblFourTwo.Font = new System.Drawing.Font("Clear Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFourTwo.Location = new System.Drawing.Point(296, 819);
            this.lblFourTwo.Margin = new System.Windows.Forms.Padding(4);
            this.lblFourTwo.Name = "lblFourTwo";
            this.lblFourTwo.Size = new System.Drawing.Size(190, 190);
            this.lblFourTwo.TabIndex = 42;
            this.lblFourTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFourOne
            // 
            this.lblFourOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFourOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.lblFourOne.Font = new System.Drawing.Font("Clear Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFourOne.Location = new System.Drawing.Point(80, 819);
            this.lblFourOne.Margin = new System.Windows.Forms.Padding(4);
            this.lblFourOne.Name = "lblFourOne";
            this.lblFourOne.Size = new System.Drawing.Size(190, 190);
            this.lblFourOne.TabIndex = 41;
            this.lblFourOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThreeFour
            // 
            this.lblThreeFour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblThreeFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.lblThreeFour.Font = new System.Drawing.Font("Clear Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreeFour.Location = new System.Drawing.Point(722, 604);
            this.lblThreeFour.Margin = new System.Windows.Forms.Padding(4);
            this.lblThreeFour.Name = "lblThreeFour";
            this.lblThreeFour.Size = new System.Drawing.Size(190, 190);
            this.lblThreeFour.TabIndex = 40;
            this.lblThreeFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThreeTwo
            // 
            this.lblThreeTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblThreeTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.lblThreeTwo.Font = new System.Drawing.Font("Clear Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreeTwo.Location = new System.Drawing.Point(296, 604);
            this.lblThreeTwo.Margin = new System.Windows.Forms.Padding(4);
            this.lblThreeTwo.Name = "lblThreeTwo";
            this.lblThreeTwo.Size = new System.Drawing.Size(190, 190);
            this.lblThreeTwo.TabIndex = 38;
            this.lblThreeTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThreeThree
            // 
            this.lblThreeThree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblThreeThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.lblThreeThree.Font = new System.Drawing.Font("Clear Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreeThree.Location = new System.Drawing.Point(511, 604);
            this.lblThreeThree.Margin = new System.Windows.Forms.Padding(4);
            this.lblThreeThree.Name = "lblThreeThree";
            this.lblThreeThree.Size = new System.Drawing.Size(190, 190);
            this.lblThreeThree.TabIndex = 39;
            this.lblThreeThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThreeOne
            // 
            this.lblThreeOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblThreeOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.lblThreeOne.Font = new System.Drawing.Font("Clear Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreeOne.Location = new System.Drawing.Point(80, 604);
            this.lblThreeOne.Margin = new System.Windows.Forms.Padding(4);
            this.lblThreeOne.Name = "lblThreeOne";
            this.lblThreeOne.Size = new System.Drawing.Size(190, 190);
            this.lblThreeOne.TabIndex = 37;
            this.lblThreeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(991, 1153);
            this.Controls.Add(this.lblFourFour);
            this.Controls.Add(this.lblFourThree);
            this.Controls.Add(this.lblFourTwo);
            this.Controls.Add(this.lblFourOne);
            this.Controls.Add(this.lblThreeFour);
            this.Controls.Add(this.lblThreeTwo);
            this.Controls.Add(this.lblThreeThree);
            this.Controls.Add(this.lblThreeOne);
            this.Controls.Add(this.lblTwoFour);
            this.Controls.Add(this.lblTwoThree);
            this.Controls.Add(this.lblTwoTwo);
            this.Controls.Add(this.lblTwoOne);
            this.Controls.Add(this.lblOneFour);
            this.Controls.Add(this.lblOneThree);
            this.Controls.Add(this.lblOneTwo);
            this.Controls.Add(this.lblOneOne);
            this.Controls.Add(this.btnShiftLeft);
            this.Controls.Add(this.btnShiftDown);
            this.Controls.Add(this.btnShiftUp);
            this.Controls.Add(this.btnShiftRight);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShiftRight;
        private System.Windows.Forms.Button btnShiftUp;
        private System.Windows.Forms.Button btnShiftDown;
        private System.Windows.Forms.Button btnShiftLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblOneOne;
        private System.Windows.Forms.Label lblOneTwo;
        private System.Windows.Forms.Label lblOneThree;
        private System.Windows.Forms.Label lblOneFour;
        private System.Windows.Forms.Label lblTwoFour;
        private System.Windows.Forms.Label lblTwoThree;
        private System.Windows.Forms.Label lblTwoOne;
        private System.Windows.Forms.Label lblTwoTwo;
        private System.Windows.Forms.Label lblFourFour;
        private System.Windows.Forms.Label lblFourThree;
        private System.Windows.Forms.Label lblFourTwo;
        private System.Windows.Forms.Label lblFourOne;
        private System.Windows.Forms.Label lblThreeFour;
        private System.Windows.Forms.Label lblThreeTwo;
        private System.Windows.Forms.Label lblThreeThree;
        private System.Windows.Forms.Label lblThreeOne;
    }
}

