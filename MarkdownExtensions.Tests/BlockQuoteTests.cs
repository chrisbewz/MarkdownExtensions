﻿using MarkdownExtensions.Types;
using Xunit;

namespace MarkdownExtensions.Tests
{
    
    public class BlockQuoteTestsap
    {
        [Fact]
        public void SimplebBlockquoteTest()
        {
            var markdownBlockQuote = new MarkdownBlockQuote();
            var expectedQuote = "> ";
            
            Assert.True(markdownBlockQuote.ToString().Equals(expectedQuote));
        }
    }
}