using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace regExpr_TextParser
{
    public partial class MainWindow : Form
    {

        string inputText;
        string regExpr;
        List<int[]> matches = new List<int[]>();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void ParseButton_Click(object sender, EventArgs e)
        {
            if (this.InputTextBox.Text == "Enter text, or open a file..." |
                this.InputTextBox.Text == "")
                return;

            if (this.RegExpTextBox.Text != "Regular expression..." & this.RegExpTextBox.Text != "Regular expression...")
            {
                //this.regExpr = createRegExprFromString(this.RegExpTextBox.Text);
                this.regExpr = this.RegExpTextBox.Text;
                this.inputText = this.InputTextBox.Text;
                this.showResult();
            }
        }

        private void ClearTextButton_Click(object sender, EventArgs e)
        {
            if (this.InputTextBox.Text != "")
            {
                this.InputTextBox.Text = "Enter text, or open a file...";
                this.InputTextBox.ForeColor = System.Drawing.Color.Silver;
                this.inputText = "";
                this.OutputTextBox.Text = "";
            }
        }

        private void OpenNewFileButtonLabel_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = OpenFileDialog.FileName;
                this.InputTextBox.Clear();
                this.InputTextBox.Text = File.ReadAllText(fileName);
            }
        }

        private void RegExpTextBox_Enter(object sender, EventArgs e)
        {
            if (this.RegExpTextBox.Text == "Regular expression...")
            {
                this.RegExpTextBox.Text = "";
                this.RegExpTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void RegExpTextBox_Leave(object sender, EventArgs e)
        {
            if (this.RegExpTextBox.Text == "")
            {
                this.RegExpTextBox.Text = "Regular expression...";
                this.RegExpTextBox.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void RegExpTextBox_TextChanged(object sender, EventArgs e)
        {
            //this.regExpr = createRegExprFromString(this.RegExpTextBox.Text);
            this.regExpr = this.RegExpTextBox.Text;
            this.matches = resultOfParsing(this.regExpr, this.inputText);
            this.highlightingMatches();
        }

        private void InputTextBox_Enter(object sender, EventArgs e)
        {
            if (this.InputTextBox.Text == "Enter text, or open a file...")
            {
                this.InputTextBox.Text = "";
                this.InputTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void InputTextBox_Leave(object sender, EventArgs e)
        {
            if (this.InputTextBox.Text == "")
            {
                this.InputTextBox.Text = "Enter text, or open a file...";
                this.InputTextBox.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.InputTextBox.Text != "Enter text, or open a file..." & this.InputTextBox.Text != "")
            {
                this.InputTextBox.ForeColor = System.Drawing.Color.Black;
                this.inputText = this.InputTextBox.Text;
                this.matches = resultOfParsing(this.regExpr, this.inputText);
                this.highlightingMatches();
            }
        }

        private List<int[]> resultOfParsing(string regExpr, string text)
        {
            //string re = createRegExprFromString(regExpr);  // формирую регулярное выражение
            List < int[] > findedPositions = new List<int[]>();
            try
            {
                Regex regex = new Regex(@regExpr);
                foreach (Match match in regex.Matches(text))
                    findedPositions.Add(new int[] {match.Index,
                                                    match.Index + match.Value.Length,
                                                    });
            }
            catch (Exception) { }
            
            return findedPositions;
        }

        private void paintMatches()
        {
            System.Drawing.Color[] colors = new System.Drawing.Color[]{
                                                System.Drawing.Color.FromArgb(122, 245, 171),
                                                System.Drawing.Color.FromArgb(237, 133, 190),
                                                };
            
            // обнуляю цветовое выделение в тексте
            this.InputTextBox.SelectAll();
            this.InputTextBox.SelectionBackColor = System.Drawing.Color.White;
            this.InputTextBox.Select(InputTextBox.Text.Length, 0);

            // прохожусь по списку найденных совпадений. его элементы int[2] - начало и конец совпадения
            for (int match = 0; match < matches.Count; match++)
            {
                int start = matches[match][0];  // начало совпадения
                int length = matches[match][1] - matches[match][0];  // его длина
                this.InputTextBox.Select(start, length);
                this.InputTextBox.SelectionBackColor = colors[match % 2];  // варьирую цвета
                this.InputTextBox.Select(InputTextBox.Text.Length, 0);  // сбрасываю выделение
            }
        }

        private void highlightingMatches()
        {
            if (
               (this.InputTextBox.Text != "Enter text, or open a file..." & this.InputTextBox.Text != "") &
               (this.RegExpTextBox.Text != "Regular expression..." & this.RegExpTextBox.Text != "")
               )
            {
                this.paintMatches();
            }
        }

        private void showResult()
        {
            foreach (int[] match in matches)
            {
                this.OutputTextBox.Text += this.inputText.Substring(match[0], match[1] - match[0]) + " ";
            }
            this.OutputTextBox.Text += "\n";
        }
    }
}
