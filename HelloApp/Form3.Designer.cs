namespace HelloApp
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            checkedListBox1 = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            checkedListBox3 = new CheckedListBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Peru;
            label1.Location = new Point(22, 74);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "все книги";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Peru;
            label2.Location = new Point(249, 74);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "автор";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Peru;
            label3.Location = new Point(463, 74);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 5;
            label3.Text = "название";
            // 
            // button1
            // 
            button1.BackColor = Color.SaddleBrown;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(22, 12);
            button1.Name = "button1";
            button1.Size = new Size(139, 46);
            button1.TabIndex = 6;
            button1.Text = "главная";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SaddleBrown;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(617, 12);
            button2.Name = "button2";
            button2.Size = new Size(139, 46);
            button2.TabIndex = 7;
            button2.Text = "добавить файл";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.Peru;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(463, 111);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(139, 312);
            checkedListBox1.TabIndex = 8;
            // 
            // checkedListBox2
            // 
            checkedListBox2.BackColor = Color.Peru;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(249, 103);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(139, 312);
            checkedListBox2.TabIndex = 9;
            // 
            // checkedListBox3
            // 
            checkedListBox3.BackColor = Color.Peru;
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Location = new Point(22, 111);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(139, 312);
            checkedListBox3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(702, 421);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 11;
            label4.Text = "anastasuuia";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(checkedListBox3);
            Controls.Add(checkedListBox2);
            Controls.Add(checkedListBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox3;
        private Label label4;
    }
}