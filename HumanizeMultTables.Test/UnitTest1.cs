using System;
using FluentAssertions;
using NUnit.Framework;


namespace HumanizeMultTables.Test
{
    public class MultTablesTest
    {
        [Test]
        public void MultiplierRowWithHeader()
        {
            MultTables.MultiplierRow(1, 3, 4).Should().Contain("three").And.Contain("four").And.Contain("one");
        }

        [Test]
        public void MultiplierRowWithoutHeader()
        {
            MultTables.MultiplierRow(1, 3, 4, header: false).Should().Contain("three").And.Contain("four").And.NotContain("one");
        }
    }
}
