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
            this.directoryBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hasResourcesCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // directoryBtn
            // 
            this.directoryBtn.Location = new System.Drawing.Point(209, 66);
            this.directoryBtn.Name = "directoryBtn";
            this.directoryBtn.Size = new System.Drawing.Size(124, 23);
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
            this.label1.Size = new System.Drawing.Size(318, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click the button below to navigate to your StoryLine output folder. \r\nI will add " +
    "your custom wrapper and zip your course for you.";
            // 
            // hasResourcesCheckBox
            // 
            this.hasResourcesCheckBox.AutoSize = true;
            this.hasResourcesCheckBox.Location = new System.Drawing.Point(18, 70);
            this.hasResourcesCheckBox.Name = "hasResourcesCheckBox";
            this.hasResourcesCheckBox.Size = new System.Drawing.Size(144, 17);
            this.hasResourcesCheckBox.TabIndex = 3;
            this.hasResourcesCheckBox.Text = "My course has resources";
            this.hasResourcesCheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ITLLNDLogo;
            this.pictureBox1.InitialImage = global::WindowsFormsApplication1.Properties.Resources.ITLLNDLogo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 104);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // CaptivateFixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 230);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hasResourcesCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.directoryBtn);
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
        private System.Windows.Forms.CheckBox hasResourcesCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

