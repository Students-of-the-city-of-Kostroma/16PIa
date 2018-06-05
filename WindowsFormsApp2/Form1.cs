using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleLexer;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void click_Click(object sender, EventArgs e)
        {
            try
            {
                LexerBox.Text = "";
                var lexer = new MathLexer();
                var tokens = lexer.Tokenize(TextBox.Text);
                foreach (var token in tokens)
                    LexerBox.Text += token + "\r\n";
            }
            catch
            {
                TextBox.Text = "error input";
            }
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            LexerBox.Text = "";
            TextBox.Text = "";
        }
        
    }
}
