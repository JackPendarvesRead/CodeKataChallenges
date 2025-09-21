using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.MirrorClock
{
    public partial class MirrorClockRegex
    {
        [GeneratedRegex(@"^(0[1-9]|1[0-2]):([0-5][0-9])$")]
        public static partial Regex InputValidationRegex();
    }
}
