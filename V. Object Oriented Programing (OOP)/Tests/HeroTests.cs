using Moq;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skeleton;

namespace Tests
{
    [TestFixture]
    public class HeroTests
    {
        private const string heroName = "Gosho";

        [Test]
        public void HeroGainsExperienceAfterAttackIfTargetDies()
        {
            Mock<ITarget> fakeTarget = new Mock<ITarget>();
            fakeTarget.Setup(p => p.Health).Returns(0);
            fakeTarget.Setup(p => p.GiveExperience()).Returns(20);
            fakeTarget.Setup(p => p.IsDead()).Returns(true);
            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();

            Hero hero = new Hero(heroName, fakeWeapon.Object);

            hero.Attack(fakeTarget.Object);

            Assert.AreEqual(20, hero.Experience, "Hero doesn't get XP when target dies");
        }
    }
}
