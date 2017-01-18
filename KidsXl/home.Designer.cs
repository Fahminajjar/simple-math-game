namespace KidsXl
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Snow;
            this.btnAdd.Location = new System.Drawing.Point(204, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(272, 111);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSub.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold);
            this.btnSub.ForeColor = System.Drawing.Color.Snow;
            this.btnSub.Location = new System.Drawing.Point(204, 358);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(272, 111);
            this.btnSub.TabIndex = 3;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(353, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 111);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.BackColor = System.Drawing.Color.Transparent;
            this.lblNum1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.ForeColor = System.Drawing.Color.Red;
            this.lblNum1.Location = new System.Drawing.Point(139, -1);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(247, 112);
            this.lblNum1.TabIndex = 5;
            this.lblNum1.Text = "KidsXl";
            // 
            // btnDiv
            // 
            this.btnDiv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDiv.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold);
            this.btnDiv.ForeColor = System.Drawing.Color.Snow;
            this.btnDiv.Location = new System.Drawing.Point(502, 358);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(272, 111);
            this.btnDiv.TabIndex = 7;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMulti.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMulti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.ForeColor = System.Drawing.Color.Snow;
            this.btnMulti.Location = new System.Drawing.Point(502, 208);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(272, 111);
            this.btnMulti.TabIndex = 6;
            this.btnMulti.Text = "x";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click_1);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KidsXl.Properties.Resources.bg4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(903, 694);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(929, 765);
            this.MinimumSize = new System.Drawing.Size(929, 765);
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KidsXl";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMulti;



    }
}