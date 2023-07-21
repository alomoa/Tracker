using Tracker;

namespace TrackerTest
{
    [TestFixture]
    public class TrackerTests
    {
        [Test]
        public void Tracker_ShouldCount_TheNumberOfTimes_ItIsCreated()
        {
            var result = TrackerEx.Execute(300, 5);
            Assert.That(result.CreateCount, Is.EqualTo(300));
        }

        [Test]
        public void Tracker_ShouldCount_TheTotalNumberOfClicks_AcrossAllTrackers()
        {
            var result = TrackerEx.Execute(300, 10);
            Assert.That(result.TotalClicksAcrossAllTrackers, Is.EqualTo(300 * 10));
        }

        [Test]
        public void Tracker_ShouldCount_TheTotalNumberOfClicks_ForATracker()
        {
            var result = TrackerEx.Execute(20, 100);
            Assert.That(result.TotalClicksForThisTracker, Is.EqualTo(100));
        }

    }
}