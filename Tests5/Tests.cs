using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;

namespace Tests5
{
    internal class Tests
    {
        [Test]
        public void Sleep1()
        {
            Thread.Sleep(1_000);
        }
    }
}
