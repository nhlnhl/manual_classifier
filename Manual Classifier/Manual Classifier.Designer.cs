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
            this.txt_curr = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MoveTo = new System.Windows.Forms.TextBox();
            this.btn_Jump = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cam2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Correct
            // 
            this.btn_Correct.Location = new System.Drawing.Point(840, 42);
            this.btn_Correct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Correct.Name = "btn_Correct";
            this.btn_Correct.Size = new System.Drawing.Size(64, 67);
            this.btn_Correct.TabIndex = 0;
            this.btn_Correct.Text = "Correct";
            this.btn_Correct.UseVisualStyleBackColor = true;
            this.btn_Correct.Click += new System.EventHandler(this.btn_Correct_Click);
            // 
            // btn_Wrong
            // 
            this.btn_Wrong.Location = new System.Drawing.Point(840, 113);
            this.btn_Wrong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Wrong.Name = "btn_Wrong";
            this.btn_Wrong.Size = new System.Drawing.Size(64, 67);
            this.btn_Wrong.TabIndex = 1;
            this.btn_Wrong.Text = "Wrong";
            this.btn_Wrong.UseVisualStyleBackColor = true;
            this.btn_Wrong.Click += new System.EventHandler(this.btn_Wrong_Click);
            // 
            // btn_Other
            // 
            this.btn_Other.Location = new System.Drawing.Point(840, 185);
            this.btn_Other.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Other.Name = "btn_Other";
            this.btn_Other.Size = new System.Drawing.Size(64, 67);
            this.btn_Other.TabIndex = 2;
            this.btn_Other.Text = "Other";
            this.btn_Other.UseVisualStyleBackColor = true;
            this.btn_Other.Click += new System.EventHandler(this.btn_Other_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(840, 324);
            this.btn_Prev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(64, 67);
            this.btn_Prev.TabIndex = 3;
            this.btn_Prev.Text = "Prev";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(840, 396);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(64, 67);
            this.btn_Next.TabIndex = 4;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // pb_cam1
            // 
            this.pb_cam1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_cam1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_cam1.Location = new System.Drawing.Point(15, 44);
            this.pb_cam1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_cam1.Name = "pb_cam1";
            this.pb_cam1.Size = new System.Drawing.Size(400, 417);
            this.pb_cam1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_cam1.TabIndex = 5;
            this.pb_cam1.TabStop = false;
            // 
            // pb_cam2
            // 
            this.pb_cam2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_cam2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_cam2.Location = new System.Drawing.Point(428, 44);
            this.pb_cam2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_cam2.Name = "pb_cam2";
            this.pb_cam2.Size = new System.Drawing.Size(400, 417);
            this.pb_cam2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_cam2.TabIndex = 6;
            this.pb_cam2.TabStop = false;
            this.pb_cam2.Click += new System.EventHandler(this.pb_cam2_Click);
            // 
            // txt_curr
            // 
            this.txt_curr.Location = new System.Drawing.Point(15, 12);
            this.txt_curr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_curr.Name = "txt_curr";
            this.txt_curr.Size = new System.Drawing.Size(81, 25);
            this.txt_curr.TabIndex = 7;
            this.txt_curr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(124, 12);
            this.txt_total.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(81, 25);
            this.txt_total.TabIndex = 8;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "of";
            // 
            // txt_MoveTo
            // 
            this.txt_MoveTo.Location = new System.Drawing.Point(679, 12);
            this.txt_MoveTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_MoveTo.Name = "txt_MoveTo";
            this.txt_MoveTo.Size = new System.Drawing.Size(81, 25);
            this.txt_MoveTo.TabIndex = 10;
            this.txt_MoveTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Jump
            // 
            this.btn_Jump.Location = new System.Drawing.Point(764, 12);
            this.btn_Jump.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Jump.Name = "btn_Jump";
            this.btn_Jump.Size = new System.Drawing.Size(64, 25);
            this.btn_Jump.TabIndex = 11;
            this.btn_Jump.Text = "Jump";
            this.btn_Jump.UseVisualStyleBackColor = true;
            this.btn_Jump.Click += new System.EventHandler(this.btn_MoveTo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 478);
            this.Controls.Add(this.btn_Jump);
            this.Controls.Add(this.txt_MoveTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_curr);
            this.Controls.Add(this.pb_cam2);
            this.Controls.Add(this.pb_cam1);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_Other);
            this.Controls.Add(this.btn_Wrong);
            this.Controls.Add(this.btn_Correct);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual Classifier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pb_cam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cam2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Correct;
        private System.Windows.Forms.Button btn_Wrong;
        private System.Windows.Forms.Button btn_Other;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.PictureBox pb_cam1;
        private System.Windows.Forms.PictureBox pb_cam2;
        private System.Windows.Forms.TextBox txt_curr;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MoveTo;
        private System.Windows.Forms.Button btn_Jump;
    }
}

