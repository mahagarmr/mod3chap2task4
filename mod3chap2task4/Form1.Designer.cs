namespace mod3chap2task4
{
    partial class Form1
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
            wordTextBox = new TextBox();
            browseButton = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            searchButton = new Button();
            label1 = new Label();
            label2 = new Label();
            fileLabel = new Label();
            SuspendLayout();
            // 
            // wordTextBox
            // 
            wordTextBox.Location = new Point(59, 105);
            wordTextBox.Name = "wordTextBox";
            wordTextBox.Size = new Size(178, 23);
            wordTextBox.TabIndex = 0;
            wordTextBox.TextChanged += wordTextBox_TextChanged;
            // 
            // browseButton
            // 
            browseButton.Location = new Point(59, 155);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(75, 23);
            browseButton.TabIndex = 1;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(162, 155);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 87);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 4;
            label1.Text = "Word";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 43);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 5;
            label2.Text = "Path:";
            // 
            // fileLabel
            // 
            fileLabel.AutoSize = true;
            fileLabel.Location = new Point(99, 43);
            fileLabel.Name = "fileLabel";
            fileLabel.Size = new Size(0, 15);
            fileLabel.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 249);
            Controls.Add(fileLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(searchButton);
            Controls.Add(browseButton);
            Controls.Add(wordTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox wordTextBox;
        private Button browseButton;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button searchButton;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label fileLabel;
    }
}