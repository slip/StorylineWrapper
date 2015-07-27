namespace WindowsFormsApplication1
{
    partial class CaptivateFixer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptivateFixer));
            this.directoryBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wrapperBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // directoryBtn
            // 
            this.directoryBtn.Location = new System.Drawing.Point(18, 119);
            this.directoryBtn.Name = "directoryBtn";
            this.directoryBtn.Size = new System.Drawing.Size(124, 21);
            this.directoryBtn.TabIndex = 1;
            this.directoryBtn.Text = "Find Course";
            this.directoryBtn.UseVisualStyleBackColor = true;
            this.directoryBtn.Click += new System.EventHandler(this.directoryBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ITLLNDLogo;
            this.pictureBox1.InitialImage = global::WindowsFormsApplication1.Properties.Resources.ITLLNDLogo;
            this.pictureBox1.Location = new System.Drawing.Point(54, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 104);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // wrapperBox
            // 
            this.wrapperBox.FormattingEnabled = true;
            this.wrapperBox.Items.AddRange(new object[] {
            "Village Wrapper with resources",
            "Village Wrapper w/o resources",
            "IT Wrapper with resources",
            "IT Wrapper w/o resources"});
            this.wrapperBox.Location = new System.Drawing.Point(18, 80);
            this.wrapperBox.Name = "wrapperBox";
            this.wrapperBox.Size = new System.Drawing.Size(209, 21);
            this.wrapperBox.TabIndex = 6;
            this.wrapperBox.Text = "Choose your wrapper";
            // 
            // CaptivateFixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 290);
            this.Controls.Add(this.wrapperBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.directoryBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CaptivateFixer";
            this.Text = "Storyline Wrapper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button directoryBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox wrapperBox;

    }
}

