using RunLengthEncoding.Logic.RunLengthEncoding;
using System.Text;

namespace CodeKataChallenges.Logic.RunLengthEncoding
{
    public class RunLengthEncoder : IEncoder
    {
        public string Decode(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) 
                return string.Empty;

            var sb = new StringBuilder();

            int count = 0;

            foreach(char currentChar in input)
            {
                if (char.IsDigit(currentChar))
                {
                    count = ParseDigitChar(count, currentChar);
                }
                else
                {
                    sb.Append(new string(currentChar, count));
                    count = 0;
                }
            }

            return sb.ToString();
        }

        public string Encode(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) 
                return string.Empty;

            var sb = new StringBuilder();
            int currentCount = 0;
            char currentCharacter = input[0];


            for (int i = 0; i < input.Length; i++)
            {
                char next = input[i];
                if (currentCharacter == next)
                {
                    currentCount++;
                }
                else
                {
                    sb.Append($"{currentCount}{currentCharacter}");
                    currentCharacter = next;
                    currentCount = 1;
                }

                if (i == input.Length - 1)
                {
                    sb.Append($"{currentCount}{currentCharacter}");
                }
            }

            return sb.ToString();
        }
        private static int ParseDigitChar(int count, char currentChar)
        {
            int value = currentChar - '0';
            if (count == 0)
            {
                count = value;
            }
            else
            {
                count = count * 10 + value;
            }

            return count;
        }
    }
}
