namespace RunLengthEncoding.Logic.RunLengthEncoding
{
    public interface IEncoder
    {
        string Encode(string input);

        string Decode(string input);
    }
}
