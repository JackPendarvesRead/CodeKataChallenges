using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.Test.MirrorClock
{
    public class MirrorClockUnitTests
    {
        [Theory]
        [InlineData("12:00", "12:00")]
        [InlineData("01:00", "11:00")]
        [InlineData("06:00", "06:00")]
        [InlineData("11:00", "01:00")]
        [InlineData("10:15", "01:45")]
        [InlineData("05:25", "06:35")]
        [InlineData("01:50", "10:10")]
        [InlineData("11:58", "12:02")]
        [InlineData("12:01", "11:59")]
        public void WhatIsTheTime_ShouldReturnCorrectTime_WhenGivenMirrorTime(string mirrorTime, string expectedTime)
        {
            // Arrange
            var mirrorClock = new Logic.MirrorClock.MirrorClock();
            // Act
            var result = mirrorClock.WhatIsTheTime(mirrorTime);
            // Assert
            Assert.Equal(expectedTime, result);
        }

        [Theory]
        [InlineData("13:00")]
        [InlineData("00:30")]
        [InlineData("10:60")]
        [InlineData("10:5")]
        [InlineData("9:30")]
        [InlineData("abc")]
        [InlineData("12-30")]
        [InlineData("1230")]
        [InlineData("")]
        [InlineData(null)]
        public void WhatIsTheTime_ShouldThrowArgumentException_WhenGivenInvalidTimeFormat(string input)
        {
            // Arrange
            var mirrorClock = new Logic.MirrorClock.MirrorClock();
            Assert.Throws<ArgumentException>(() => mirrorClock.WhatIsTheTime(input));
        }
    }
}
