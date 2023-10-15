namespace Minesweeper_Project
{
    partial class GameForm
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
            this.title = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.flagnum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.difficultyp = new System.Windows.Forms.Panel();
            this.b20 = new System.Windows.Forms.Button();
            this.b15 = new System.Windows.Forms.Button();
            this.b10 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.difficultyp.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.title.ForeColor = System.Drawing.Color.Coral;
            this.title.Location = new System.Drawing.Point(214, 522);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(179, 31);
            this.title.TabIndex = 0;
            this.title.Text = "MineSweeper";
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Black;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.reset.ForeColor = System.Drawing.Color.Coral;
            this.reset.Location = new System.Drawing.Point(224, 566);
            this.reset.Margin = new System.Windows.Forms.Padding(2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(156, 42);
            this.reset.TabIndex = 1;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // flagnum
            // 
            this.flagnum.AutoSize = true;
            this.flagnum.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flagnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.flagnum.ForeColor = System.Drawing.Color.Coral;
            this.flagnum.Location = new System.Drawing.Point(286, 678);
            this.flagnum.Name = "flagnum";
            this.flagnum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flagnum.Size = new System.Drawing.Size(0, 25);
            this.flagnum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(263, 644);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Flags";
            // 
            // difficultyp
            // 
            this.difficultyp.Controls.Add(this.b20);
            this.difficultyp.Controls.Add(this.b15);
            this.difficultyp.Controls.Add(this.b10);
            this.difficultyp.Controls.Add(this.b5);
            this.difficultyp.Controls.Add(this.label2);
            this.difficultyp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.difficultyp.Location = new System.Drawing.Point(0, 0);
            this.difficultyp.Margin = new System.Windows.Forms.Padding(2);
            this.difficultyp.Name = "difficultyp";
            this.difficultyp.Size = new System.Drawing.Size(600, 715);
            this.difficultyp.TabIndex = 5;
            // 
            // b20
            // 
            this.b20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b20.ForeColor = System.Drawing.Color.Coral;
            this.b20.Location = new System.Drawing.Point(411, 97);
            this.b20.Margin = new System.Windows.Forms.Padding(2);
            this.b20.Name = "b20";
            this.b20.Size = new System.Drawing.Size(106, 50);
            this.b20.TabIndex = 8;
            this.b20.Text = "100";
            this.b20.UseVisualStyleBackColor = true;
            this.b20.Click += new System.EventHandler(this.Difficulty100Button);
            // 
            // b15
            // 
            this.b15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b15.ForeColor = System.Drawing.Color.Coral;
            this.b15.Location = new System.Drawing.Point(301, 97);
            this.b15.Margin = new System.Windows.Forms.Padding(2);
            this.b15.Name = "b15";
            this.b15.Size = new System.Drawing.Size(106, 50);
            this.b15.TabIndex = 7;
            this.b15.Text = "81";
            this.b15.UseVisualStyleBackColor = true;
            this.b15.Click += new System.EventHandler(this.Difficulty81Button);
            // 
            // b10
            // 
            this.b10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b10.ForeColor = System.Drawing.Color.Coral;
            this.b10.Location = new System.Drawing.Point(191, 97);
            this.b10.Margin = new System.Windows.Forms.Padding(2);
            this.b10.Name = "b10";
            this.b10.Size = new System.Drawing.Size(106, 50);
            this.b10.TabIndex = 6;
            this.b10.Text = "64";
            this.b10.UseVisualStyleBackColor = true;
            this.b10.Click += new System.EventHandler(this.Difficulty64Button);
            // 
            // b5
            // 
            this.b5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b5.ForeColor = System.Drawing.Color.Coral;
            this.b5.Location = new System.Drawing.Point(81, 97);
            this.b5.Margin = new System.Windows.Forms.Padding(2);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(106, 50);
            this.b5.TabIndex = 4;
            this.b5.Text = "49";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.Difficulty49Button);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(143, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Difficulty";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(600, 715);
            this.Controls.Add(this.difficultyp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flagnum);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "MineSweeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.difficultyp.ResumeLayout(false);
            this.difficultyp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label flagnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel difficultyp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b15;
        private System.Windows.Forms.Button b10;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b20;
    }
}

