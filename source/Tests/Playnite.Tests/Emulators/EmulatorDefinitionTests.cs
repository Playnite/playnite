﻿using NUnit.Framework;
using Playnite.Emulators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playnite.Tests.Emulators
{
    [TestFixture]
    public class EmulatorDefinitionTest
    {
        [Test]
        public void GetDefinitionsTest()
        {
            CollectionAssert.IsNotEmpty(EmulatorDefinition.Definitions);
        }
    }
}
