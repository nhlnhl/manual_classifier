namespace Manual_Classifier
{
    partial class Form1
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
            this.btn_Correct = new System.Windows.Forms.Button();
            this.btn_Wrong = new System.Windows.Forms.Button();
            this.btn_Other = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.pb_cam1 = new System.Windows.Forms.PictureBox();
            this.pb_cam2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cam2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Correct
            // 
            this.btn_Correct.Location = new System.Drawing.Point(1266, 20);
            this.btn_Correct.Name = "btn_Correct";
            this.btn_Correct.Size = new System.Drawing.Size(100, 100);
            this.btn_Correct.TabIndex = 0;
            this.btn_Correct.Text = "Correct";
            this.btn_Correct.UseVisualStyleBackColor = true;
            this.btn_Correct.Click += new System.EventHandler(this.btn_Correct_Click);
            // 
            // btn_Wrong
            // 
            this.btn_Wrong.Location = new System.Drawing.Point(1266, 126);
            this.btn_Wrong.Name = "btn_Wrong";
            this.btn_Wrong.Size = new System.Drawing.Size(100, 100);
            this.btn_Wrong.TabIndex = 1;
            this.btn_Wrong.Text = "Wrong";
            this.btn_Wrong.UseVisualStyleBackColor = true;
            this.btn_Wrong.Click += new System.EventHandler(this.btn_Wrong_Click);
            // 
            // btn_Other
            // 
            this.btn_Other.Location = new System.Drawing.Point(1266, 232);
            this.btn_Other.Name = "btn_Other";
            this.btn_Other.Size = new System.Drawing.Size(100, 100);
            this.btn_Other.TabIndex = 2;
            this.btn_Other.Text = "Other";
            this.btn_Other.UseVisualStyleBackColor = true;
            this.btn_Other.Click += new System.EventHandler(this.btn_Other_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(1266, 414);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(100, 100);
            this.btn_Prev.TabIndex = 3;
            this.btn_Prev.Text = "Prev";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(1266, 520);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(100, 100);
            this.btn_Next.TabIndex = 4;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // pb_cam1
            // 
            this.pb_cam1.Location = new System.Drawing.Point(24, 20);
            this.pb_cam1.Name = "pb_cam1";
            this.pb_cam1.Size = new System.Drawing.Size(600, 600);
            this.pb_cam1.TabIndex = 5;
            this.pb_cam1.TabStop = false;
            // 
            // pb_cam2
            // 
            this.pb_cam2.Location = new System.Drawing.Point(642, 20);
            this.pb_cam2.Name = "pb_cam2";
            this.pb_cam2.Size = new System.Drawing.Size(600, 600);
            this.pb_cam2.TabIndex = 6;
            this.pb_cam2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 639);
            this.Controls.Add(this.pb_cam2);
            this.Controls.Add(this.pb_cam1);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_Other);
            this.Controls.Add(this.btn_Wrong);
            this.Controls.Add(this.btn_Correct);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Manual Classifier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pb_cam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cam2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Correct;
        private System.Windows.Forms.Button btn_Wrong;
        private System.Windows.Forms.Button btn_Other;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.PictureBox pb_cam1;
        private System.Windows.Forms.PictureBox pb_cam2;
    }
}

