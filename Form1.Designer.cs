namespace Matrici_2
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.Teaching = new System.Windows.Forms.PictureBox();
            this.Practice = new System.Windows.Forms.PictureBox();
            this.Quizz = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Teaching)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Practice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quizz)).BeginInit();
            this.SuspendLayout();
            // 
            // Teaching
            // 
            this.Teaching.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Teaching.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Teaching.Image = ((System.Drawing.Image)(resources.GetObject("Teaching.Image")));
            this.Teaching.Location = new System.Drawing.Point(41, 86);
            this.Teaching.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Teaching.Name = "Teaching";
            this.Teaching.Size = new System.Drawing.Size(402, 360);
            this.Teaching.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Teaching.TabIndex = 0;
            this.Teaching.TabStop = false;
            this.Teaching.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Practice
            // 
            this.Practice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Practice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Practice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Practice.Image = ((System.Drawing.Image)(resources.GetObject("Practice.Image")));
            this.Practice.Location = new System.Drawing.Point(470, 86);
            this.Practice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Practice.Name = "Practice";
            this.Practice.Size = new System.Drawing.Size(384, 360);
            this.Practice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Practice.TabIndex = 1;
            this.Practice.TabStop = false;
            this.Practice.Click += new System.EventHandler(this.Practice_Click);
            // 
            // Quizz
            // 
            this.Quizz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Quizz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Quizz.Image = ((System.Drawing.Image)(resources.GetObject("Quizz.Image")));
            this.Quizz.Location = new System.Drawing.Point(896, 86);
            this.Quizz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Quizz.Name = "Quizz";
            this.Quizz.Size = new System.Drawing.Size(390, 360);
            this.Quizz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Quizz.TabIndex = 2;
            this.Quizz.TabStop = false;
            this.Quizz.Click += new System.EventHandler(this.Quizz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "PREDARE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(566, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "EXERCIȚII";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(989, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "TESTARE";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Matrici_2.Properties.Resources.coding;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1298, 523);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quizz);
            this.Controls.Add(this.Practice);
            this.Controls.Add(this.Teaching);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrici";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Teaching)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Practice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quizz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Teaching;
        private System.Windows.Forms.PictureBox Practice;
        private System.Windows.Forms.PictureBox Quizz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

