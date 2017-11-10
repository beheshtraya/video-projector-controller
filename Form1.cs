using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ControlProjector
{
    public partial class Form1 : Form
    {
        Form other = new Form();
        Label lblSubContainer = new Label();
        Label lblTitle = new Label();
        Label lblSubtitle = new Label();
        StreamReader f;
        string lines;
        PictureBox logo = new PictureBox();
        Dictionary<string, string> settings = new Dictionary<string, string>();
        int apply_count = 0;
        string subtitle_path = "subtitle.txt";
        string setting_path = "settings.conf";
        string kmPlayer_path = "C:\\Program Files (x86)\\KMPlayer\\KMPlayer.exe";
        int speed = 1;

        public Form1()
        {
            InitializeComponent();

            StreamWriter conf = new StreamWriter(setting_path, true);
            conf.Close();

            StreamWriter sw = new StreamWriter(subtitle_path, true);
            sw.Close();

            read_subtitle();

            txtx.Text = "0";
            txty.Text = "655";
            txtWidth.Text = Screen.AllScreens[1].Bounds.Width.ToString();
            txtHeight.Text = "50";

            foreach (string s in lines.Split('\n'))
                    comboBoxSubText.Items.Add(s.Split(';')[0]);
            
            Screen.FromControl(other);

            other.FormBorderStyle = FormBorderStyle.None;
            
            other.Bounds = Screen.AllScreens[1].Bounds;
            other.TopMost = true;

            comboBoxSubSource.SelectedIndex = 1;
        }

        private void btnStartFlash_Click(object sender, EventArgs e)
        {
            flashObj.Movie = openFileFlash.FileName;
            flashObj.Bounds = other.Bounds;
            other.Controls.Add(flashObj);
            other.Show();
        }

        private void btnApplySubtitle_Click(object sender, EventArgs e)
        {
            read_subtitle();

            if (apply_count == 2)
            {
                apply_count = 0;
                return;
            }

            apply_count++;

            set_configuration();

            
            if (chboxSubtitle.Checked)
            {
                lblSubContainer.Left = flashObj.Left;
                lblSubContainer.Width = Convert.ToInt32(txtWidth.Text);
                lblSubContainer.BackColor = Color.FromName(settings["Subtitle Background Color"]);
                lblSubContainer.Height = lblSubtitle.Font.Height;
                lblSubContainer.BorderStyle = BorderStyle.None;
                lblSubContainer.Top = Convert.ToInt32(txty.Text);  //// Screen.AllScreens[1].Bounds.Height - lblSubContainer.Height;////Convert.ToInt32(txty.Text);
                lblSubContainer.Show();

                if (comboBoxSubText.SelectedIndex != -1)
                    txtSubtitle.Text = lines.Split('\n')[comboBoxSubText.SelectedIndex].Split(';')[2];

                lblSubtitle.Text = txtSubtitle.Text;

                if (settings["Subtitle Font Bold"] == "True")
                    lblSubtitle.Font = new Font(settings["Subtitle Font Family"], Convert.ToInt32(settings["Subtitle Font Size"]), FontStyle.Bold);
                else
                    lblSubtitle.Font = new Font(settings["Subtitle Font Family"], Convert.ToInt32(settings["Subtitle Font Size"]));


                lblSubtitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

                lblSubtitle.AutoSize = true;
                lblSubtitle.BackColor = Color.Transparent;
                lblSubtitle.ForeColor = Color.FromName(settings["Subtitle Foreground Color"]);

                logo.Image = Image.FromFile("logo.gif"); /// logo.BackgroundImage = Image.FromFile(openFileLogo.FileName);
                logo.SetBounds(0, 0, lblSubtitle.Font.Height, lblSubtitle.Font.Height);
                logo.SizeMode = PictureBoxSizeMode.StretchImage;
                logo.BorderStyle = BorderStyle.None;

                lblSubContainer.Controls.Add(lblSubtitle);
                lblSubContainer.Controls.Add(logo);
                other.Controls.Add(lblSubContainer);

                lblSubtitle.SendToBack();
                lblSubtitle.Left = lblSubContainer.Left - lblSubtitle.Width;

                timer1.Start();
            }
            else
            {
                lblSubContainer.Hide();
            }

            if (chboxTitle.Checked)
            {
                lblTitle.Show();
                if (comboBoxSubText.SelectedIndex != -1)
                    txtTitle.Text = lines.Split('\n')[comboBoxSubText.SelectedIndex].Split(';')[1];

                lblTitle.Text = txtTitle.Text;

                if (settings["Title Font Bold"] == "True")
                    lblTitle.Font = new Font(settings["Title Font Family"], Convert.ToInt32(settings["Title Font Size"]), FontStyle.Bold);
                else
                    lblTitle.Font = new Font(settings["Title Font Family"], Convert.ToInt32(settings["Title Font Size"]));

                lblTitle.BackColor = Color.FromName(settings["Title Background Color"]);
                lblTitle.ForeColor = Color.FromName(settings["Title Foreground Color"]);
                lblTitle.AutoSize = true;
                lblTitle.Left = lblSubContainer.Width - lblTitle.Width;
                lblTitle.Top = lblSubContainer.Top + lblTitle.Height;

                other.Controls.Add(lblTitle);
            }
            else
            {
                lblTitle.Hide();
            }


            btnStartFlash_Click(sender, e);
            btnApplySubtitle_Click(sender, e);
        }

        private void btnPlayVideo_Click(object sender, EventArgs e)
        {
            btnPlayVideo.Enabled = false;
            
            Process p = new Process();
            p.StartInfo.FileName = kmPlayer_path;
            p.StartInfo.Arguments = "";
            
            foreach (string fileName in openFileVideo.FileNames)
            {
                p.StartInfo.Arguments += "\"" + fileName + "\" ";
            }
            p.StartInfo.Arguments = p.StartInfo.Arguments.Substring(0, p.StartInfo.Arguments.Length - 1);

            p.Start();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(subtitle_path, true);
            sw.WriteLine(txtInputItem.Text + ";" + txtInputTitle.Text + ";" + txtInputSubtitle.Text);
            sw.Close();

            btnRefreshSubtitle_Click(sender, e);
            txtInputItem.Text = "";
            txtInputTitle.Text = "";
            txtInputSubtitle.Text = "";
        }
        
        private void set_configuration()
        {
            StreamReader sr = new StreamReader(setting_path);
            string settingsString = sr.ReadToEnd();
            sr.Close();

            settings.Clear();

            foreach (string line in settingsString.Split('\n'))
            {
                if (!line.Trim().StartsWith("#") && line.Contains("="))
                {
                    string key, value;
                    key = line.Split('=')[0].Trim();
                    value = line.Split('=')[1].Trim();
                    settings.Add(key, value);
                }
            }
        }

        private void btnRefreshSubtitle_Click(object sender, EventArgs e)
        {
            f = File.OpenText(subtitle_path);
            lines = f.ReadToEnd();
            f.Close();

            comboBoxSubText.Items.Clear();

            foreach (string s in lines.Split('\n'))
                comboBoxSubText.Items.Add(s.Split(';')[0]);

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblSubtitle.Location = new Point(lblSubtitle.Location.X + speed, lblSubtitle.Location.Y);
            if (lblSubtitle.Location.X > Screen.AllScreens[1].WorkingArea.Left - 100)
            {
                lblSubtitle.Location = new Point(lblSubContainer.Left - lblSubtitle.Width, lblSubtitle.Location.Y);
            }
        }

        //// -----------------------------------------------------------
        //// -----------------------------------------------------------
        //// -----------------------------------------------------------

        private void btnBrowseFlash_Click(object sender, EventArgs e)
        {
            openFileFlash.ShowDialog();
        }

        private void openFileFlash_FileOk(object sender, CancelEventArgs e)
        {
            lblFlashFileName.Text = openFileFlash.FileName;
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            openFileVideo.ShowDialog();
            btnPlayVideo.Enabled = true;
        }

        private void btnLogoImage_Click(object sender, EventArgs e)
        {
            openFileLogo.ShowDialog();
        }

        private void comboBoxSubSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSubSource.SelectedIndex == 1)
            {
                lblComboSubText.Show();
                comboBoxSubText.Show();
                btnRefreshSubtitle.Show();
            }
            else
            {
                lblComboSubText.Hide();
                comboBoxSubText.Hide();
                btnRefreshSubtitle.Hide();
            }
        }

        private void btnPauseSubtitle_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnResumeSubtitle_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            speed = Convert.ToInt32(numericUpDown1.Value);
        }

        private void btnClosePlayer_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "TASKKILL";
            p.StartInfo.Arguments = "/IM kmplayer.exe";
            p.Start();
        }

        private void openFileVideo_FileOk(object sender, CancelEventArgs e)
        {
            lblVideos.Text = "";
            foreach (string fileName in openFileVideo.FileNames)
            {
                int i = fileName.LastIndexOf('\\');
                lblVideos.Text += fileName.Substring(i+1) + "\n";
            }
        }

        private void btnTitleFont_Click(object sender, EventArgs e)
        {
            fontDialogTitle.ShowDialog();
        }

        private void btnSubtitleFont_Click(object sender, EventArgs e)
        {
            fontDialogSubtitle.ShowDialog();
        }

        private void btnSaveFont_Click(object sender, EventArgs e)
        {
            StreamWriter conf = new StreamWriter("settings.conf", false);

            conf.WriteLine("Title Font Family = " + fontDialogTitle.Font.FontFamily.Name);
            conf.WriteLine("Title Font Size = " + Convert.ToInt32(fontDialogTitle.Font.Size).ToString());
            conf.WriteLine("Title Font Bold = " + fontDialogTitle.Font.Bold.ToString());
            conf.WriteLine("Title Background Color = " + colorDialogTitleBackground.Color.Name);
            conf.WriteLine("Title Foreground Color = " + colorDialogTitleForeground.Color.Name);

            conf.WriteLine("Subtitle Font Family = " + fontDialogSubtitle.Font.FontFamily.Name);
            conf.WriteLine("Subtitle Font Size = " + Convert.ToInt32(fontDialogSubtitle.Font.Size).ToString());
            conf.WriteLine("Subtitle Font Bold = " + fontDialogSubtitle.Font.Bold.ToString());
            conf.WriteLine("Subtitle Background Color = " + colorDialogSubBackground.Color.Name);
            conf.WriteLine("Subtitle Foreground Color = " + colorDialogSubForeground.Color.Name);

            conf.Close();

            tabFont_Enter(sender, e);
            
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void fontDialogTitle_Apply(object sender, EventArgs e)
        {
            lblTitleFont.Font = fontDialogTitle.Font;
        }

        private void fontDialogSubtitle_Apply(object sender, EventArgs e)
        {
            lblSubtitleFont.Font = fontDialogSubtitle.Font;
        }

        private void tabFont_Enter(object sender, EventArgs e)
        {
            set_configuration();

            if (settings["Title Font Bold"] == "True")
            {
                lblTitleFont.Font = new Font(settings["Title Font Family"], Convert.ToInt32(settings["Title Font Size"]), FontStyle.Bold);
                fontDialogTitle.Font = lblTitleFont.Font;
            }
            else
            {
                lblTitleFont.Font = new Font(settings["Title Font Family"], Convert.ToInt32(settings["Title Font Size"]));
                fontDialogTitle.Font = lblTitleFont.Font;
            }
            
            lblTitleFont.BackColor = Color.FromName(settings["Title Background Color"]);
            colorDialogTitleBackground.Color = lblTitleFont.BackColor;
            lblTitleFont.ForeColor = Color.FromName(settings["Title Foreground Color"]);
            colorDialogTitleForeground.Color = lblTitleFont.ForeColor;

            if (settings["Subtitle Font Bold"] == "True")
            {
                lblSubtitleFont.Font = new Font(settings["Subtitle Font Family"], Convert.ToInt32(settings["Subtitle Font Size"]), FontStyle.Bold);
                fontDialogSubtitle.Font = lblSubtitleFont.Font;
            }
            else
            {
                lblSubtitleFont.Font = new Font(settings["Subtitle Font Family"], Convert.ToInt32(settings["Subtitle Font Size"]));
                fontDialogSubtitle.Font = lblSubtitleFont.Font;
            }

            lblSubtitleFont.BackColor = Color.FromName(settings["Subtitle Background Color"]);
            colorDialogSubBackground.Color = lblSubtitleFont.BackColor;
            lblSubtitleFont.ForeColor = Color.FromName(settings["Subtitle Foreground Color"]);
            colorDialogSubForeground.Color = lblSubtitleFont.ForeColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialogTitleBackground.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialogTitleForeground.ShowDialog();
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            colorDialogSubBackground.ShowDialog();
        }

        private void btnForeColor_Click(object sender, EventArgs e)
        {
            colorDialogSubForeground.ShowDialog();
        }

        private void txty_ValueChanged(object sender, EventArgs e)
        {
            lblSubContainer.Top = Convert.ToInt32(txty.Text);
            lblTitle.Top = lblSubContainer.Top + lblTitle.Height + 100;
        }

        private void read_subtitle()
        {
            f = File.OpenText(subtitle_path);
            lines = f.ReadToEnd();
            f.Close();
        }

    }
}
