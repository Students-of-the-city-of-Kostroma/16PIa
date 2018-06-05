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
    }
}
