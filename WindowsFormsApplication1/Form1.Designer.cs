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
            this.SuspendLayout();
            // 
            // directoryBtn
            // 
            this.directoryBtn.Location = new System.Drawing.Point(286, 45);
            this.directoryBtn.Name = "directoryBtn";
            this.directoryBtn.Size = new System.Drawing.Size(124, 23);
            this.directoryBtn.TabIndex = 1;
            this.directoryBtn.Text = "Fix My Course";
            this.directoryBtn.UseVisualStyleBackColor = true;
            this.directoryBtn.Click += new System.EventHandler(this.directoryBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click below to choose the directory of your Captivate course. We\'ll handle the re" +
    "st.";
            // 
            // hasResourcesCheckBox
            // 
            this.hasResourcesCheckBox.AutoSize = true;
            this.hasResourcesCheckBox.Location = new System.Drawing.Point(167, 51);
            this.hasResourcesCheckBox.Name = "hasResourcesCheckBox";
            this.hasResourcesCheckBox.Size = new System.Drawing.Size(99, 17);
            this.hasResourcesCheckBox.TabIndex = 3;
            this.hasResourcesCheckBox.Text = "Resources Tab";
            this.hasResourcesCheckBox.UseVisualStyleBackColor = true;
            // 
            // CaptivateFixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 92);
            this.Controls.Add(this.hasResourcesCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.directoryBtn);
            this.Name = "CaptivateFixer";
            this.Text = "Storyline Wrapper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button directoryBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox hasResourcesCheckBox;

    }
}

