using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class AxeTests
    {
        private const int AxeAtack = 2;
        private const int AxeDurability = 2;
        private const int DummyHealth = 10;
        private const int DummyXP = 10;
        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void AxeTestsInit()
        {
            this.axe = new Axe(AxeAtack, AxeDurability);
            this.dummy = new Dummy(DummyHealth, DummyXP);
        }
        
        [Test]
        public void AxeLosesDurabilityAfterAtack()
        {
            axe.Attack(dummy);

            Assert.AreEqual(1, axe.DurabilityPoints, "Axe Durability doesn't change after an Atack");
        }

        [Test]
        public void BrokenAxeCantAtack()
        {
            axe.Attack(dummy);
            axe.Attack(dummy);

            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(ex.Message, Is.EqualTo("Axe is broken."));
        }
    }
}
