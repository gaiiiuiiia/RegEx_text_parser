namespace regExpr_TextParser
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputTextBox = new System.Windows.Forms.RichTextBox();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.RegExpTextBox = new System.Windows.Forms.TextBox();
            this.OpenNewFileButtonLabel = new System.Windows.Forms.Label();
            this.AboutButtonLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ClearTextButton = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextBox.ForeColor = System.Drawing.Color.Silver;
            this.InputTextBox.Location = new System.Drawing.Point(10, 90);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(370, 459);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.Text = "Enter text, or open a file...";
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            this.InputTextBox.Enter += new System.EventHandler(this.InputTextBox_Enter);
            this.InputTextBox.Leave += new System.EventHandler(this.InputTextBox_Leave);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OutputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputTextBox.Location = new System.Drawing.Point(402, 90);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(370, 459);
            this.OutputTextBox.TabIndex = 1;
            this.OutputTextBox.Text = "";
            // 
            // RegExpTextBox
            //
            this.RegExpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegExpTextBox.ForeColor = System.Drawing.Color.Silver;
            this.RegExpTextBox.Location = new System.Drawing.Point(10, 30);
            this.RegExpTextBox.Name = "RegExpTextBox";
            this.RegExpTextBox.Size = new System.Drawing.Size(760, 20);
            this.RegExpTextBox.TabIndex = 2;
            this.RegExpTextBox.Text = "Regular expression...";
            this.RegExpTextBox.TextChanged += new System.EventHandler(this.RegExpTextBox_TextChanged);
            this.RegExpTextBox.Enter += new System.EventHandler(this.RegExpTextBox_Enter);
            this.RegExpTextBox.Leave += new System.EventHandler(this.RegExpTextBox_Leave);
            // 
            // OpenNewFileButtonLabel
            // 
            this.OpenNewFileButtonLabel.AutoSize = true;
            this.OpenNewFileButtonLabel.Location = new System.Drawing.Point(10, 10);
            this.OpenNewFileButtonLabel.Name = "OpenNewFileButtonLabel";
            this.OpenNewFileButtonLabel.Size = new System.Drawing.Size(33, 13);
            this.OpenNewFileButtonLabel.TabIndex = 3;
            this.OpenNewFileButtonLabel.Text = "Open";
            this.OpenNewFileButtonLabel.Click += new System.EventHandler(this.OpenNewFileButtonLabel_Click);
            // 
            // AboutButtonLabel
            // 
            this.AboutButtonLabel.AutoSize = true;
            this.AboutButtonLabel.Location = new System.Drawing.Point(50, 10);
            this.AboutButtonLabel.Name = "AboutButtonLabel";
            this.AboutButtonLabel.Size = new System.Drawing.Size(35, 13);
            this.AboutButtonLabel.TabIndex = 4;
            this.AboutButtonLabel.Text = "About";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(10, 60);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 23);
            this.ParseButton.TabIndex = 5;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ClearTextButton
            // 
            this.ClearTextButton.Location = new System.Drawing.Point(100, 60);
            this.ClearTextButton.Name = "ClearTextButton";
            this.ClearTextButton.Size = new System.Drawing.Size(75, 23);
            this.ClearTextButton.TabIndex = 6;
            this.ClearTextButton.Text = "Clear text";
            this.ClearTextButton.UseVisualStyleBackColor = true;
            this.ClearTextButton.Click += new System.EventHandler(this.ClearTextButton_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ClearTextButton);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.AboutButtonLabel);
            this.Controls.Add(this.OpenNewFileButtonLabel);
            this.Controls.Add(this.RegExpTextBox);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Regular Expression Text Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InputTextBox;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.TextBox RegExpTextBox;
        private System.Windows.Forms.Label OpenNewFileButtonLabel;
        private System.Windows.Forms.Label AboutButtonLabel;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.Button ClearTextButton;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}

