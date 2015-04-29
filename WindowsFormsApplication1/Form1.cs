using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class CaptivateFixer : Form
    {
        // 
        string folderPath = "";
        string docPath = "";
        string destinationPath = "";

        public CaptivateFixer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void directoryBtn_Click(object sender, EventArgs e)
        {

            // get the folder we want to search and update the folderPath
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
                docPath = folderPath + "\\story.html";
                destinationPath = folderPath + "\\story_content\\frame.swf";

            }

            // check to make sure directory is valid, throw error if not
            if (!File.Exists(docPath))
            {
                MessageBox.Show("This doesn't seem to be a StoryLine course. Please choose the directory of your course output folder.");
            }
            // copy frame.swf into directory/story_content
            else
            {
                // get correct frameswf
                if (hasResourcesCheckBox.Checked)
                {
                    File.WriteAllBytes(destinationPath, Resources.frame_wResources);
                }
                else
                {
                    File.WriteAllBytes(destinationPath, Resources.frame_noResources);
                }
            }

            // replace lines in story.html et al
        }

        private void CopyResource(string resourceName, string file)
        {
            using (Stream resource = GetType().Assembly.GetManifestResourceStream(resourceName))
            {
                if (resource == null)
                {
                    throw new ArgumentException("No such resource", "resourceName");
                }
                using (Stream output = File.OpenWrite(file))
                {
                    resource.CopyTo(output);
                }
            }
        }
    }
}