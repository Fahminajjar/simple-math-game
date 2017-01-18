namespace KidsXl
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWrong = new System.Windows.Forms.Label();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.BackColor = System.Drawing.Color.Transparent;
            this.lblNum1.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.ForeColor = System.Drawing.Color.Red;
            this.lblNum1.Location = new System.Drawing.Point(66, 45);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(175, 229);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "5";
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn1.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Bold);
            this.btn1.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn1.Location = new System.Drawing.Point(262, 532);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(283, 234);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "10";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Bold);
            this.btn2.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn2.Location = new System.Drawing.Point(551, 532);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(283, 234);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "15";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Bold);
            this.btn3.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn3.Location = new System.Drawing.Point(840, 532);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(283, 234);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "20";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Mistral", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Red;
            this.lblScore.Location = new System.Drawing.Point(159, 34);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(67, 83);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "0";
            this.lblScore.TextChanged += new System.EventHandler(this.lblScore_TextChanged);
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.BackColor = System.Drawing.Color.Transparent;
            this.lblOp.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.ForeColor = System.Drawing.Color.Red;
            this.lblOp.Location = new System.Drawing.Point(286, 45);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(146, 229);
            this.lblOp.TabIndex = 6;
            this.lblOp.Text = "-";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.BackColor = System.Drawing.Color.Transparent;
            this.lblNum2.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.ForeColor = System.Drawing.Color.Red;
            this.lblNum2.Location = new System.Drawing.Point(483, 45);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(179, 229);
            this.lblNum2.TabIndex = 7;
            this.lblNum2.Text = "9";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::KidsXl.Properties.Resources.apple;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 124);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblWrong);
            this.panel1.Controls.Add(this.lblNum1);
            this.panel1.Controls.Add(this.lblOp);
            this.panel1.Controls.Add(this.lblNum2);
            this.panel1.Location = new System.Drawing.Point(284, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 309);
            this.panel1.TabIndex = 8;
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.BackColor = System.Drawing.Color.Transparent;
            this.lblWrong.Font = new System.Drawing.Font("Segoe Print", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong.ForeColor = System.Drawing.Color.Red;
            this.lblWrong.Location = new System.Drawing.Point(224, 242);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(310, 65);
            this.lblWrong.TabIndex = 9;
            this.lblWrong.Text = "Wrong answer!";
            this.lblWrong.Visible = false;
            // 
            // star1
            // 
            this.star1.BackColor = System.Drawing.Color.Transparent;
            this.star1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("star1.BackgroundImage")));
            this.star1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.star1.Location = new System.Drawing.Point(258, 45);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(60, 53);
            this.star1.TabIndex = 9;
            this.star1.TabStop = false;
            this.star1.Visible = false;
            // 
            // star2
            // 
            this.star2.BackColor = System.Drawing.Color.Transparent;
            this.star2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("star2.BackgroundImage")));
            this.star2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.star2.Location = new System.Drawing.Point(324, 45);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(60, 53);
            this.star2.TabIndex = 10;
            this.star2.TabStop = false;
            this.star2.Visible = false;
            // 
            // star3
            // 
            this.star3.BackColor = System.Drawing.Color.Transparent;
            this.star3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("star3.BackgroundImage")));
            this.star3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.star3.Location = new System.Drawing.Point(390, 45);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(60, 53);
            this.star3.TabIndex = 11;
            this.star3.TabStop = false;
            this.star3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KidsXl.Properties.Resources.bg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1446, 881);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1472, 952);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KidsXL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.PictureBox star1;
        private System.Windows.Forms.PictureBox star2;
        private System.Windows.Forms.PictureBox star3;
    }
}

