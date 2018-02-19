using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Manual_Classifier
{
    public partial class Form1 : Form
    {
        FileInfo[] images1 = null;
        FileInfo[] images2 = null;

        private int max;
        private int idx;

        Dictionary<string, int> result = new Dictionary<string, int>();     // result dictionary 
        string filePath = @"./classifier.out";  // file path to be saved

        public Form1()
        {
            InitializeComponent();

            DirectoryInfo dir1 = new DirectoryInfo(@"./cam1");  // you sould change here based on your developing environment
            DirectoryInfo dir2 = new DirectoryInfo(@"./cam2");  // you sould change here based on your developing environment

            // save images in directory
            images1 = dir1.GetFiles("*.jpg", SearchOption.AllDirectories);
            images2 = dir2.GetFiles("*.jpg", SearchOption.AllDirectories);

            max = images1.Length;
            idx = 0;

            txt_total.Text = max.ToString();

            // if result file exists
            if(System.IO.File.Exists(filePath))
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    string line = String.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line[line.Length - 1] != '0')
                        {
                            idx++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            // if there is no file
            else
            {
                using (StreamWriter output = new StreamWriter(filePath))
                {
                    foreach(FileInfo file in images1)
                    {
                        output.WriteLine(file.Name + " 0");
                    }
                }
            }

            setImage();
        }

        // set a pair of images
        private void setImage()
        {
            txt_curr.Text = (idx + 1).ToString();
            Bitmap nowImage1 = new Bitmap(images1[idx].FullName);
            pb_cam1.Image = nowImage1;
            Bitmap nowImage2 = new Bitmap(images2[idx].FullName);
            pb_cam2.Image = nowImage2;
        }

        private void showPrevErr()
        {
            if (MessageBox.Show("There is no previous image.", "", MessageBoxButtons.OK) == DialogResult.No)
            {
                this.Close();
            }
        }

        private void showNextErr()
        {
            if (MessageBox.Show("There is no next image.", "", MessageBoxButtons.OK) == DialogResult.No)
            {
                this.Close();
            }
        }

        private void movePrev()
        {
            idx--;
            if (idx == -1 || idx == -2) 
            {
                showPrevErr();
                idx++;
            }
            else
            {
                setImage();
            }
        }

        private void moveNext()
        {
            idx++;
            if (idx == max)
            {
                showNextErr();
                idx--;
            }
            else
            {
                setImage();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_MoveTo_Click(sender, e);
            }
            else if (idx == -1 && e.KeyCode == Keys.Left)
            {
                showPrevErr();
            }
            else if (idx == max && e.KeyCode == Keys.Right)
            {
                showNextErr();
            }
            else if (idx != -1 && idx != max)
            {
                // Correct (1)
                if (e.KeyCode == Keys.NumPad1)
                {
                    result[images1[idx].Name] = 1;
                    moveNext();
                }
                // Wrong (2)
                else if (e.KeyCode == Keys.NumPad2)
                {
                    result[images1[idx].Name] = 2;
                    moveNext();
                }
                // Other (3)
                else if (e.KeyCode == Keys.NumPad3)
                {
                    result[images1[idx].Name] = 3;
                    moveNext();
                }
            }
            // Prev (Left Arrow)
            else if (e.KeyCode == Keys.Left)
            {
                movePrev();
            }
            // Next (Right Arrow)
            else if (e.KeyCode == Keys.Right)
            {
                moveNext();
            }
            // Close (ESC)
            else if (e.KeyCode == Keys.Escape)
            {
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    int position = 0;   // the position is 0 at first
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line = String.Empty;
                        while ((line = sr.ReadLine()) != null)
                        {
                            int count = line.LastIndexOf(' ');
                            string name = line;
                            name = line.Substring(0, count);
                            // get name from the line

                            if (result.ContainsKey(name))
                            {
                                byte[] bytes = BitConverter.GetBytes(result[name]);
                                fs.Seek(position + name.Length + 1, SeekOrigin.Begin);
                                // move to the position before writing
                                fs.Write(bytes, 0, bytes.Length);
                            }

                            position += line.Length;
                            position += 2;
                            // update the position
                        }
                    }
                }
                // save the file before quitting

                if (MessageBox.Show("Do you want to exit?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        private void btn_Correct_Click(object sender, EventArgs e)
        {
            if(idx == -1)
            {
                showPrevErr();
            }
            else if(idx == max)
            {
                showNextErr();
            }
            else if (idx != -1 && idx != max)
            {
                result[images1[idx].Name] = 1;
                moveNext();
            }
        }

        private void btn_Wrong_Click(object sender, EventArgs e)
        {
            if (idx == -1)
            {
                showPrevErr();
            }
            else if (idx == max)
            {
                showNextErr();
            }
            else if (idx != -1 && idx != max)
            {
                result[images1[idx].Name] = 2;
                moveNext();
            }
        }

        private void btn_Other_Click(object sender, EventArgs e)
        {
            if (idx == -1)
            {
                showPrevErr();
            }
            else if (idx == max)
            {
                showNextErr();
            }
            else if (idx != -1 && idx != max)
            {
                result[images1[idx].Name] = 3;
                moveNext();
            }
        }

        private void btn_MoveTo_Click(object sender, EventArgs e)
        {
            int i;
            for(i = 0; i < max; i++)
            {
                if (images1[i].Name.Replace(".jpg", "") == txt_MoveTo.Text.ToString())
                {
                    idx = i;
                    setImage();
                    txt_MoveTo.Text = null;
                    return;
                }
            }

            if (MessageBox.Show("There is no such image.", "", MessageBoxButtons.OK) == DialogResult.No)
            {
                this.Close();
            }
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            movePrev();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            moveNext();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                int position = 0;   // the position is 0 at first
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = String.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        int count = line.LastIndexOf(' ');
                        string name = line;
                        if (count != -1)
                        {
                            name = line.Substring(0, count);
                        }
                        // get name from the line
                        
                        if (result.ContainsKey(name))
                        {
                            string str = result[name].ToString();
                            byte[] bytes = Encoding.ASCII.GetBytes(str);
                            fs.Seek(position + name.Length + 1, SeekOrigin.Begin);
                            // move to the position before writing
                            fs.Write(bytes, 0, bytes.Length);
                        }

                        position += line.Length;
                        position += 2;
                        // update the position
                    }
                }
            }
            // save the file before quitting

            if (MessageBox.Show("Do you want to exit?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    };
};