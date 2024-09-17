namespace Assignment1
{
    partial class frnMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fnameLabel = new Label();
            lnameLabel = new Label();
            workLabel = new Label();
            fnameTextBox = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            sumBtn = new Button();
            clearBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Location = new Point(186, 97);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new Size(80, 20);
            fnameLabel.TabIndex = 0;
            fnameLabel.Text = "&First Name";
            fnameLabel.Click += label1_Click;
            // 
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.Location = new Point(385, 97);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new Size(79, 20);
            lnameLabel.TabIndex = 0;
            lnameLabel.Text = "Last Name";
            // 
            // workLabel
            // 
            workLabel.AutoSize = true;
            workLabel.Location = new Point(584, 97);
            workLabel.Name = "workLabel";
            workLabel.Size = new Size(103, 20);
            workLabel.TabIndex = 0;
            workLabel.Text = "Hours Worked";
            // 
            // fnameTextBox
            // 
            fnameTextBox.Location = new Point(186, 140);
            fnameTextBox.Name = "fnameTextBox";
            fnameTextBox.Size = new Size(193, 27);
            fnameTextBox.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(385, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(584, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 27);
            textBox2.TabIndex = 3;
            // 
            // sumBtn
            // 
            sumBtn.Location = new Point(186, 212);
            sumBtn.Name = "sumBtn";
            sumBtn.Size = new Size(94, 29);
            sumBtn.TabIndex = 4;
            sumBtn.Text = "Summarize";
            sumBtn.UseVisualStyleBackColor = true;
            sumBtn.Click += button1_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(306, 212);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 29);
            clearBtn.TabIndex = 6;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(186, 268);
            label1.Name = "label1";
            label1.Size = new Size(591, 98);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // frnMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 591);
            Controls.Add(label1);
            Controls.Add(clearBtn);
            Controls.Add(sumBtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(fnameTextBox);
            Controls.Add(workLabel);
            Controls.Add(lnameLabel);
            Controls.Add(fnameLabel);
            Name = "frnMain";
            Text = "1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fnameLabel;
        private Label lnameLabel;
        private Label workLabel;
        private TextBox fnameTextBox;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button sumBtn;
        private Button clearBtn;
        private Label label1;
    }
}
