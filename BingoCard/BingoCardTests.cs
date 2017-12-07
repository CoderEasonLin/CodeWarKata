using NUnit.Framework;

namespace BingoCard
{
    [TestFixture]
    public class BingoCardTests
    {
        [Test]
        public void CardHas24Numbers()
        {
            Assert.AreEqual(24, BingoCard.GetCard().Length);
        }
    }
}