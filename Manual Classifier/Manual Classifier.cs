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

        public Form1()
        {
            InitializeComponent();

            DirectoryInfo dir1 = new DirectoryInfo(@"폴더경로");
            DirectoryInfo dir2 = new DirectoryInfo(@"폴더경로");
            
            // 폴더 내 이미지 저장
            FileInfo[] pic1 = dir1.GetFiles("*.jpg", SearchOption.AllDirectories);
            FileInfo[] pic2 = dir2.GetFiles("*.jpg", SearchOption.AllDirectories);

            images1 = new FileInfo[pic1.Length];
            images2 = new FileInfo[pic2.Length];

            pic1.CopyTo(images1, 0);
            pic2.CopyTo(images2, 0);

            // 변수 값 설정
            max += pic1.Length;
            idx = 0;

            // 분류된 파일 존재
            if(System.IO.File.Exists("파일경로"))
            {

            }
            // 분류된 파일 없음
            else
            {
                Bitmap nowImage1 = new Bitmap(images1[idx].FullName);
                pb_cam1.Image = nowImage1;
                Bitmap nowImage2 = new Bitmap(images2[idx].FullName);
                pb_cam2.Image = nowImage2;
            }

            result = new Dictionary<string, int>();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Correct (1)
            if(e.KeyCode == Keys.NumPad1)
            {
                result.Add(images1[idx].FullName, 1);
            }
            // Wrong (2)
            else if(e.KeyCode == Keys.NumPad2)
            {
                result.Add(images1[idx].FullName, 2);
            }
            // Other (3)
            else if(e.KeyCode == Keys.NumPad3)
            {
                result.Add(images1[idx].FullName, 3);
            }
            // Prev (Left Arrow)
            else if(e.KeyCode == Keys.Left)
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
                    Bitmap nowImage1 = new Bitmap(images1[idx].FullName);
                    pb_cam1.Image = nowImage1;
                    Bitmap nowImage2 = new Bitmap(images2[idx].FullName);
                    pb_cam2.Image = nowImage2;
                }
            }
            // Next (Right Arrow)
            else if (e.KeyCode == Keys.Right)
            {
                idx++;
                if (idx == max)
                {
                    Message err = new Message();
                    err.Text = "There is no later image.";
                    err.Show();
                }
                else
                {
                    Bitmap nowImage1 = new Bitmap(images1[idx].FullName);
                    pb_cam1.Image = nowImage1;
                    Bitmap nowImage2 = new Bitmap(images2[idx].FullName);
                    pb_cam2.Image = nowImage2;
                }
            }
            // Close (ESC)
            else if(e.KeyCode == Keys.Escape)
            {
                // 파일 저장
                Application.Exit();
            }
        }

        private void btn_Correct_Click(object sender, EventArgs e)
        {
            result.Add(images1[idx].FullName, 1);
        }

        private void btn_Wrong_Click(object sender, EventArgs e)
        {
            result.Add(images1[idx].FullName, 2);
        }

        private void btn_Other_Click(object sender, EventArgs e)
        {
            result.Add(images1[idx].FullName, 3);
        }

        private void btn_Prev_Click(object sender, EventArgs e)
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
                Bitmap nowImage1 = new Bitmap(images1[idx].FullName);
                pb_cam1.Image = nowImage1;
                Bitmap nowImage2 = new Bitmap(images2[idx].FullName);
                pb_cam2.Image = nowImage2;
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            idx++;
            if (idx == max)
            {
                Message err = new Message();
                err.Text = "There is no later image.";
                err.Show();
            }
            else
            {
                Bitmap nowImage1 = new Bitmap(images1[idx].FullName);
                pb_cam1.Image = nowImage1;
                Bitmap nowImage2 = new Bitmap(images2[idx].FullName);
                pb_cam2.Image = nowImage2;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Append))
            {
                using (TextWriter tw = new StreamWriter(fs))
                {
                    foreach (KeyValuePair<string, int> kvp in result)
                    {
                        tw.WriteLine(string.Format("{0} {1}", kvp.Key, kvp.Value));
                    }
                }
            }
            // 파일 저장

            e.Cancel = true;
        }
    }
}
