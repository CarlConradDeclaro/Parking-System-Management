﻿namespace Parking
{
    partial class parkinList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(parkinList));
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            label11 = new Label();
            label3 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Ebrima", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(28, 13);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "9807oipu";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Ebrima", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(229, 12);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "SUV";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Ebrima", 9F, FontStyle.Bold);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(634, 12);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 6;
            label7.Text = "2/6/2024";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Ebrima", 9F, FontStyle.Bold);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(875, 14);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 7;
            label8.Text = "3:43 PM";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1160, 11);
            button1.Name = "button1";
            button1.Size = new Size(32, 29);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1231, 9);
            button2.Name = "button2";
            button2.Size = new Size(33, 29);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Ebrima", 9F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(404, 13);
            label11.Name = "label11";
            label11.Size = new Size(45, 20);
            label11.TabIndex = 12;
            label11.Text = "Tesla";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Ebrima", 9F, FontStyle.Bold);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(1040, 14);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "PARKED";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(1199, 9);
            button3.Name = "button3";
            button3.Size = new Size(32, 29);
            button3.TabIndex = 13;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // parkinList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 22, 71);
            Controls.Add(button3);
            Controls.Add(label11);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "parkinList";
            Size = new Size(1305, 49);
            Load += parkinList_Load;
            Click += parkinList_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
        private Label label11;
        private Label label3;
        private Button button3;
    }
}
