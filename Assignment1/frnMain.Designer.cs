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
            lnameTextBox = new TextBox();
            workTextBox = new TextBox();
            sumBtn = new Button();
            clearBtn = new Button();
            summaryLabel = new Label();
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
            // 
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.Location = new Point(385, 97);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new Size(79, 20);
            lnameLabel.TabIndex = 0;
            lnameLabel.Text = "&Last Name";
            // 
            // workLabel
            // 
            workLabel.AutoSize = true;
            workLabel.Location = new Point(584, 97);
            workLabel.Name = "workLabel";
            workLabel.Size = new Size(103, 20);
            workLabel.TabIndex = 0;
            workLabel.Text = "&Hours Worked";
            // 
            // fnameTextBox
            // 
            fnameTextBox.Location = new Point(186, 140);
            fnameTextBox.Name = "fnameTextBox";
            fnameTextBox.Size = new Size(193, 27);
            fnameTextBox.TabIndex = 1;
            fnameTextBox.TextChanged += fnameTextBox_TextChanged;
            // 
            // lnameTextBox
            // 
            lnameTextBox.Location = new Point(385, 140);
            lnameTextBox.Name = "lnameTextBox";
            lnameTextBox.Size = new Size(193, 27);
            lnameTextBox.TabIndex = 2;
            // 
            // workTextBox
            // 
            workTextBox.ImeMode = ImeMode.NoControl;
            workTextBox.Location = new Point(584, 140);
            workTextBox.Name = "workTextBox";
            workTextBox.Size = new Size(193, 27);
            workTextBox.TabIndex = 3;
            // 
            // sumBtn
            // 
            sumBtn.Location = new Point(186, 212);
            sumBtn.Name = "sumBtn";
            sumBtn.Size = new Size(94, 29);
            sumBtn.TabIndex = 4;
            sumBtn.Text = "&Summarize";
            sumBtn.UseVisualStyleBackColor = true;
            sumBtn.Click += submit_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(306, 212);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 29);
            clearBtn.TabIndex = 6;
            clearBtn.Text = "&Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clear_Click;
            // 
            // summaryLabel
            // 
            summaryLabel.Anchor = AnchorStyles.None;
            summaryLabel.BorderStyle = BorderStyle.FixedSingle;
            summaryLabel.Location = new Point(186, 268);
            summaryLabel.Name = "summaryLabel";
            summaryLabel.Size = new Size(591, 98);
            summaryLabel.TabIndex = 0;
            summaryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frnMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 591);
            Controls.Add(summaryLabel);
            Controls.Add(clearBtn);
            Controls.Add(sumBtn);
            Controls.Add(workTextBox);
            Controls.Add(lnameTextBox);
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
        private TextBox lnameTextBox;
        private TextBox workTextBox;
        private Button sumBtn;
        private Button clearBtn;
        private Label summaryLabel;
    }
}
