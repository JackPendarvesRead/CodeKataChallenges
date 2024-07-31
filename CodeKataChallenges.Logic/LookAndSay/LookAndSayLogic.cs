using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.LookAndSay
{
    public class LookAndSayLogic
    {
        public string GetNthTerm(int n)
        {
            if(n <= 0)
            {
                return "";
            }

            string s = "1";
            for(int i = 1; i < n; i++)
            {
                s = GetNextTerm(s);
            }

            return s;
        }

        private string GetNextTerm(string prev)
        {
            var sb = new StringBuilder();
            int count = 0;
            char current = 'x';
            foreach(char c in prev)
            {
                if(c != current)
                {
                    if(count > 0)
                    {
                        sb.Append(count);
                        sb.Append(current);
                    }

                    current = c;
                    count = 0;
                }
                count++;
            }

            if(count > 0)
            {
                sb.Append(count);
                sb.Append(current);
            }

            return sb.ToString();
        }
    }
}
