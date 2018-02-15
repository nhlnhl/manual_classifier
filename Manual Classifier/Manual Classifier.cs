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

        Dictionary<string, int> result; // result dictionary 
        string filePath = @"./classifier.out";  // file path to be saved

        private string extractFileName(string fullName)
        {
            int position = fullName.LastIndexOf('\\');
            string fileName = fullName.Substring(position + 1);
            return fileName;
        }

        private void setImage()
        {
            Bitmap nowImage1 = new Bitmap(images1[idx].FullName);
            pb_cam1.Image = nowImage1;
            Bitmap nowImage2 = new Bitmap(images2[idx].FullName);
            pb_cam2.Image = nowImage2;
        }

        private void movePrev()
        {
            idx--;
            if (idx == -1)
            {
                Message err = new Message();
                err.Text = "There is no previous image.";
                err.Show();
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
                Message err = new Message();
                err.Text = "There is no next image.";
                err.Show();
            }
            else
            {
                setImage();
            }
        }

        public Form1()
        {
            InitializeComponent();

            DirectoryInfo dir1 = new DirectoryInfo(@"./cam1");  // you sould change here based on your developing environment
            DirectoryInfo dir2 = new DirectoryInfo(@"./cam2");  // you sould change here based on your developing environment

            // save images in directory
            FileInfo[] pic1 = dir1.GetFiles("*.jpg", SearchOption.AllDirectories);
            FileInfo[] pic2 = dir2.GetFiles("*.jpg", SearchOption.AllDirectories);

            images1 = new FileInfo[pic1.Length];
            images2 = new FileInfo[pic2.Length];

            pic1.CopyTo(images1, 0);
            pic2.CopyTo(images2, 0);

            max += pic1.Length;
            idx = 0;

            // file exist
            if (System.IO.File.Exists(filePath))
            {
                /*
                string[] lines = System.IO.File.ReadAllLines(filePath);
                int position = lines[idx].LastIndexOf(' ');
                string fileName = lines[idx].Substring(0, position);
                while (extractFileName(images1[idx].FullName) == fileName)
                {
                    idx++;
                    position = lines[idx].LastIndexOf(' ');
                    fileName = lines[idx].Substring(0, position);
                }
                */
                
                for (int i = 0; i < max; i++)
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        bool found = false;
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            int position = line.LastIndexOf(' ');
                            string fileName = line.Substring(0, position);
                            if (fileName == extractFileName(images1[i].FullName))
                            {
                                found = true;
                                break;
                            }
                        }
                        if(!found)
                        {
                            idx = i;
                            break;
                        }
                    }
                }
            }

            setImage();

            result = new Dictionary<string, int>();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (idx != -1 && idx != max)
            {
                // Correct (1)
                if (e.KeyCode == Keys.NumPad1)
                {
                    result[extractFileName(images1[idx].FullName)] = 1;
                    //result.Add(images1[idx].FullName, 1);
                    moveNext();
                }
                // Wrong (2)
                else if (e.KeyCode == Keys.NumPad2)
                {
                    result[extractFileName(images1[idx].FullName)] = 2;
                    //result.Add(images1[idx].FullName, 2);
                    moveNext();
                }
                // Other (3)
                else if (e.KeyCode == Keys.NumPad3)
                {
                    result[extractFileName(images1[idx].FullName)] = 3;
                    //result.Add(images1[idx].FullName, 3);
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
                // save the file before quitting


                Application.Exit();
            }
        }

        private void btn_Correct_Click(object sender, EventArgs e)
        {
            if (idx != -1 && idx != max)
            {
                result[extractFileName(images1[idx].FullName)] = 1;
                //result.Add(images1[idx].FullName, 1);
                moveNext();
            }
        }

        private void btn_Wrong_Click(object sender, EventArgs e)
        {
            if (idx != -1 && idx != max)
            {
                result[extractFileName(images1[idx].FullName)] = 2;
                //result.Add(images1[idx].FullName, 2);
                moveNext();
            }
        }

        private void btn_Other_Click(object sender, EventArgs e)
        {
            if (idx != -1 && idx != max)
            {
                result[extractFileName(images1[idx].FullName)] = 3;
                //result.Add(images1[idx].FullName, 3);
                moveNext();
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
            // save the file before quitting
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                using (TextWriter tw = new StreamWriter(fs))
                {
                    if (System.IO.File.Exists(filePath))
                    {
                        foreach (KeyValuePair<string, int> kvp in result)
                        {
                            using (StreamReader sr = new StreamReader(filePath))
                            {
                                string buffer = sr.Read().ToString();

                                while (!sr.EndOfStream)
                                {
                                    if (buffer == kvp.Key)
                                    {
                                        fs.Seek(kvp.Key.Length, SeekOrigin.Current);
                                        tw.Write(kvp.Value);
                                        break;
                                    }
                                    fs.Seek(kvp.Key.Length + kvp.Value.ToString().Length, SeekOrigin.Current);
                                }
                                tw.WriteLine(string.Format("{0} {1}", kvp.Key, kvp.Value));
                            }
                        }
                    }
                    else
                    {
                        foreach (KeyValuePair<string, int> kvp in result)
                        {
                            tw.WriteLine(string.Format("{0} {1}", kvp.Key, kvp.Value));
                        }
                    }
                    //
                    e.Cancel = true;
                }
            }
        }
    }
};