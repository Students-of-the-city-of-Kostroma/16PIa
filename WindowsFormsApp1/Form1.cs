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
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static bool but=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void click_Click(object sender, EventArgs e)
        {
            try
                {
                LexerBox.Text = "";
                if (but == false)
                {
                    Lexer lexer = new Lexer(TextBox.Text, LexerBox.Text);
                    var tokens = lexer.Tokenize(TextBox.Text);
                    foreach (var token in tokens)
                        LexerBox.Text += token + "\r\n";
                }
                else
                {
                    Lexer lexer = new Lexer(TextBox.Text, LexerBox.Text, but);
                    var tokens = lexer.Tokenize(TextBox.Text);
                    foreach (var token in tokens)
                        LexerBox.Text += token + "\r\n";
                }
                //lexer.AddDefinition(new TokenDefinition(
                //    "(operator)",
                //    new Regex(@"\*|\/|\+|\-")));

                //lexer.AddDefinition(new TokenDefinition(
                //    "(literal)",
                //    new Regex(@"\d+")));


                //lexer.AddDefinition(new TokenDefinition(
                //    "(white-space)",
                //    new Regex(@"\s+"),
                //    true));
                but = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            but = true;
        }
    }
}
