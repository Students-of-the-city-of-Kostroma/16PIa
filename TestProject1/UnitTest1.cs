using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleLexer;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private void CheckTokens(IEnumerable<Token> src, params string[] items)
        {
            List<Token> tokens = new List<Token>(src);
            Assert.AreEqual(items.Length, 2 * tokens.Count, "Неверное число токенов");
            for (int i = 0; i < tokens.Count; i++)
            {
                Assert.AreEqual(items[2 * i], tokens[i].Type);
                Assert.AreEqual(items[2 * i + 1], tokens[i].Value);
            }
        }
        [TestMethod]
        public void TestMethod1()
        {
            MathLexer l = new MathLexer();
            CheckTokens(l.Tokenize("2 + 3"),
                "(literal)", "2",
                "(operator)", "+",
                "(literal)", "3"
                );
        }
       
        [TestMethod]
        public void TestMethod2()
        {
            MathLexer lexer = new MathLexer();
            CheckTokens(lexer.Tokenize("5"),
                "(literal)", "5"
                );
        }
        [TestMethod]
        public void TestMethod3()
        {
            MathLexer l = new MathLexer();
            CheckTokens(l.Tokenize("-3"),
                "(operator)", "-",
                "(literal)", "3"
                );
        }

        [TestMethod]
        public void TestMethod4()
        {
            MathLexer lexer = new MathLexer();
            CheckTokens(lexer.Tokenize("-2-(-3)"),
                "(operator)", "-",
                "(literal)", "2",
                "(operator)", "-",
                "(parenthesis)", "(",
                "(operator)", "-",
                "(literal)", "3",
                "(parenthesis)", ")"
                );
        }
        [TestMethod]
        public void TestMethod5()
        {
            MathLexer lexer = new MathLexer();
            CheckTokens(lexer.Tokenize("-2+(-3)"),
                "(operator)", "-",
                "(literal)", "2",
                "(operator)", "+",
                "(parenthesis)", "(",
                "(operator)", "-",
                "(literal)", "3",
                "(parenthesis)", ")"
                );
        }
        [TestMethod]
        public void TestMethod6()
        {
            MathLexer lexer = new MathLexer();
            CheckTokens(lexer.Tokenize("-1"),
                "(operator)", "-",
                "(literal)", "1"
                );
        }
        [TestMethod]
        public void TestMethod7()
        {
            MathLexer lexer = new MathLexer();
            CheckTokens(lexer.Tokenize("1.2"),
                "(literal)", "1.2"
                );
        }
        [TestMethod]
        public void TestMethod8()
        {
            MathLexer lexer = new MathLexer();
            CheckTokens(lexer.Tokenize("-1.2"),
                "(operator)", "-",
                "(literal)", "1.2"
                );
        }
        public void TestMethod9()
        {
            MathLexer lexer = new MathLexer();
            CheckTokens(lexer.Tokenize("90*(-4)"),
                "(literal)", "90",
                "(operator)", "*",
                "(parenthesis)", "(",
                "(operator)", "-",
                "(literal)", "4",
                "(parenthesis)", ")"
                );
        }
        [TestMethod]
        public void TestMethod10()
        {
            MathLexer lexer = new MathLexer();
            CheckTokens(lexer.Tokenize("-09/03"),
                "(operator)", "-",
                "(literal)", "09",
                "(operator)", "/",
                "(literal)", "03"
                );
        }
        [TestMethod]
        public void TestMethod11()
        {
            MathLexer lexer = new MathLexer();
            CheckTokens(lexer.Tokenize("-09/(-03)"),
                "(operator)", "-",
                "(literal)", "09",
                "(operator)", "/",
                "(parenthesis)", "(",
                "(operator)", "-",
                "(literal)", "03",
                "(parenthesis)", ")"
                );
        }
        [TestMethod]
        public void TestMethod12()
        {
            MathLexer lexer = new MathLexer();
            CheckTokens(lexer.Tokenize("10-7/(2)"),
                "(literal)", "10",
                "(operator)", "-",
                "(literal)", "7",
                "(operator)", "/",
                "(parenthesis)", "(",
                "(literal)", "2",
                "(parenthesis)", ")"
                );
        }
        [TestMethod]
        public void TestMethod13()
        {
            MathLexer lexer = new MathLexer();
            CheckTokens(lexer.Tokenize("1.2+6-(-4)"),
                "(literal)", "1.2",
                "(operator)", "+",
                "(literal)", "6",
                "(operator)", "-",
                "(parenthesis)", "(",
                "(operator)", "-",
                "(literal)", "4",
                "(parenthesis)", ")"
                );
        }
        [TestMethod]
        public void TestMethod14()
        {
            MathLexer lexer = new MathLexer();
            CheckTokens(lexer.Tokenize("-2e"),
                "(operator)", "-",
                "(literal)", "2e"
                );
        }
        [TestMethod]
        public void TestMethod15()
        {
            MathLexer lexer = new MathLexer();
            CheckTokens(lexer.Tokenize("1.8e+6"),
                "(literal)", "1.8e+6"
                );
        }
        [TestMethod]
        public void TestMethod16()
        {
            MathLexer lexer = new MathLexer();
            CheckTokens(lexer.Tokenize("-1.8e+6"),
                "(operator)", "-",
                "(literal)", "1.8e+6"
                );
        }
    }

}
