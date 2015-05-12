using System;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class CaptivateFixer : Form
    {
        // 
        string folderPath = "";
        string zipPath = "";
        string storyPath = "";
        string html5Path = "";
        string unsupportedPath = "";
        string framePath = "";

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
                storyPath = folderPath + "\\story.html";
                html5Path = folderPath + "\\story_html5.html";
                unsupportedPath = folderPath + "\\story_unsupported.html";
                framePath = folderPath + "\\story_content\\frame.swf";
            }

            // check to make sure directory is valid, throw error if not
            if (!File.Exists(storyPath))
            {
                MessageBox.Show("This doesn't seem to be a StoryLine course. Please choose the directory of your course output folder.");
            }
            // copy frame.swf into directory/story_content
            else
            {
                string html = File.ReadAllText(storyPath);
                string title = getTitle(html);

                zipPath = folderPath + "\\..\\" + title + ".zip";

                string updatedStory = replaceTitle(title, Resources.story);
                string updatedStory_html5 = replaceTitle(title, Resources.story_html5);

                File.WriteAllText(storyPath, updatedStory);
                File.WriteAllText(html5Path, updatedStory_html5);

                // get correct frameswf
                if (hasResourcesCheckBox.Checked)
                {
                    File.WriteAllBytes(framePath, Resources.frame_wResources);
                }
                else
                {
                    File.WriteAllBytes(framePath, Resources.frame_noResources);
                }
            }

            // check to see if the zip already exists.
            // if it does, delete it then recreate it.
            if (!File.Exists(zipPath))
            {
                // zip the directory
                ZipFile.CreateFromDirectory(folderPath, zipPath);
            }
            else
            {
                File.Delete(zipPath);
                ZipFile.CreateFromDirectory(folderPath, zipPath);
            }

            MessageBox.Show("All done. You will find your zip file in the same directory as your course.");
        }

        private string replaceTitle(string title, string resourceFile)
        {
            string input = resourceFile;
            string pattern = @"<title>\s*(.+?)\s*</title>";
            string replacement = "<title>" + title + "</title>";

            Regex rgx = new Regex(pattern);
            string updatedStory = rgx.Replace(input, replacement);
            return updatedStory;
        }

        static string getTitle(string file)
        {
            Match m = Regex.Match(file, @"<title>\s*(.+?)\s*</title>");
            if (m.Success)
            {
                return m.Groups[1].Value;
            }
            else
            {
                return "Couldn't find title";
            }
        }


    }
}