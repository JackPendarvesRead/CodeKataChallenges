using System.Text.RegularExpressions;

namespace CodeKataChallenges.Logic.MirrorClock
{
    public class MirrorClock
    {
        private static Regex inputValidationRegex = new Regex(@"^(0[1-9]|1[0-2]):([0-5][0-9])$");

        public string WhatIsTheTime(string timeInMirror)
        {
            if(string.IsNullOrWhiteSpace(timeInMirror))
            {
                throw new ArgumentException("Input time cannot be null or empty");
            }

            if (!inputValidationRegex.IsMatch(timeInMirror))
            {
                throw new ArgumentException("Input time is not in the correct format (hh:mm) where hh is between 01-12 and mm is between 00-59");
            }

            var timeParts = timeInMirror.Split(':');
            var hours = int.Parse(timeParts[0]);
            var minutes = int.Parse(timeParts[1]);

            minutes = minutes == 0  ? 0 : 60 - minutes;
            hours = 12 - hours - (minutes == 0 ? 0 : 1);
            if(hours < 1)
            {
                hours += 12;
            }

            return $"{hours:D2}:{minutes:D2}";
        }
    }
}
