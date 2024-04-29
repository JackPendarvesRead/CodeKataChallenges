using CodeKataChallenges.Logic.RunLengthEncoding;
using FluentAssertions;
using FluentAssertions.Execution;
using System.Runtime.CompilerServices;

namespace CodeKataChallenges.Logic.Test.RunLengthEncoding
{
    public class RunLengthEncoderTests
    {     
        #region Tests

        [Theory]
        [MemberData(nameof(GetEncodeData))]
        public void Encode_should_return_expected_output(string input, string expectedOutput)
        {
            var encoder = new RunLengthEncoder();

            var output = encoder.Encode(input);

            output.Should().Be(expectedOutput);
        }

        [Theory]
        [MemberData(nameof(GetDecodeData))]
        public void Decode_should_return_expected_output(string input, string expectedOutput)
        {
            var encoder = new RunLengthEncoder();

            var output = encoder.Decode(input);

            output.Should().Be(expectedOutput);
        }

        [Fact (Skip = "Not needed as instructions assume correct input format")]
        public void Decode_should_throw_exception_on_invalid_input()
        {
            var encoder = new RunLengthEncoder();

            Action action = () => encoder.Decode("This is an invalid string");

            action.Should().Throw<InvalidOperationException>();
        }

        #endregion

        #region Member Data

        public static IEnumerable<object[]> GetEncodeData()
        {
            var list = new List<object[]>();
            foreach (var (Decoded, Encoded) in TestCasePairs)
            {
                list.Add(new object[] { Decoded, Encoded });
            }
            return list;            
        }

        public static IEnumerable<object[]> GetDecodeData()
        {
            var list = new List<object[]>();
            foreach (var (Decoded, Encoded) in TestCasePairs)
            {
                list.Add(new object[] { Encoded, Decoded});
            }
            return list;
        }

        private static readonly IEnumerable<(string Decoded, string Encoded)> TestCasePairs =
        [
              ("AAABBBCCC", "3A3B3C"),
              ("AAABBBCCC", "3A3B3C"),
              ("ABCDEFG", "1A1B1C1D1E1F1G"),
              ("AaBbCc", "1A1a1B1b1C1c"),
              ("AAddDDDccc", "2A2d3D3c"),
              ("AAAAAAAAAAAAAAA", "15A"),
              ("AAABBBBBBBBBBCCCAAAAAAAAAAAA", "3A10B3C12A")
        ];

        #endregion
    }
}
