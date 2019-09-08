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
    public class DummyTests
    {
        private const string HeroName = "Gosho";
        private const int DummyHealth = 20;
        private const int DummyXP = 10;
        private Hero hero;
        private Dummy dummy;

        [SetUp]
        public void DummyTestsInit()
        {
            this.hero = new Hero(HeroName);
            this.dummy = new Dummy(DummyHealth, DummyXP);
        }

        [Test]
        public void DummyLosesHealthWhenAtcked()
        {
            hero.Attack(dummy);

            Assert.AreEqual(10, dummy.Health, "Dummy doesn't take damage when atacked");
        }

        [Test]
        public void DeadDummyCantBeAtacked()
        {
            hero.Attack(dummy);
            hero.Attack(dummy);

            var ex = Assert.Throws<InvalidOperationException>(() => hero.Attack(dummy));
            Assert.That(ex.Message, Is.EqualTo("Dummy is dead."));
        }

        [Test]
        public void DeadDummyGivesXP()
        {
            hero.Attack(dummy);
            hero.Attack(dummy);

            Assert.AreEqual(10, dummy.GiveExperience(), "Dummy doesn't dive XP when dead");
        }

        [Test]
        public void LiveDummyDoesntGiveXP()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
            Assert.That(ex.Message, Is.EqualTo("Target is not dead."));

        }
    }
}
