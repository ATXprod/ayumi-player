using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace AU_AudioPlayer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Global things

        string selectedSong;

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateListBox(queueList, Environment.CurrentDirectory + "/Music", "*.wav");
        }

        private void PopulateListBox(ListBox lsb, string Folder, string FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                lsb.Items.Add(file.Name);
            }
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                this.BackgroundImage = new Bitmap(open.FileName);
                // image file path  
                string bgPath = open.FileName;
            }
        }

        private void queueList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSong = Environment.CurrentDirectory + @"\Music" + queueList.SelectedItem.ToString();
            MessageBox.Show(selectedSong);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if(playButton.Text == "")
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = selectedSong;
                if(selectedSong == "")
                {
                    return;
                }
                player.Load();
                player.Play();
                playButton.Text = "";
            }
            else
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = selectedSong;
                player.Stop();
                playButton.Text = "";
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = "ATXBeats";
            string password = "ATXprodz";

            if((username+password) == (userBox + password))
            {
                string message = "Login success!";
                string title = "Login complete!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            }
            else
            {
                string message = "Login failed! Please try again and make sure you have used the correct spelling.";
                string title = "Login failed!";
                MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            }
        }
    }
}
