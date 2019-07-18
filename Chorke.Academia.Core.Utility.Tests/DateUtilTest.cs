using System;
using Xunit;
using Chorke.Academia.Core.Utility;

namespace Chorke.Academia.Core.Utility.Tests
{
    public class DateUtilTest
    {
        [Fact]
        public void FormatTest()
        {
            DateTime date = new DateTime(1983, 10, 10);
            String actual = DateUtil.Format(date, DateUtil.DD_MM_YYYY);
            Assert.Equal("10/10/1983", actual);

            date = new DateTime(1983, 10, 10, 10, 10, 10, 10);
            actual = DateUtil.Format(date, DateUtil.ISO_DATE);
            Assert.Equal("1983-10-10T10:10:10.010", actual);
        }
    }
}
