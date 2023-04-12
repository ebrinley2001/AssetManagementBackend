namespace AssetManagement.BC.Helpers
{
    public interface IStringHelpers
    {
        public string decryptDES(string ciphertext);
        public string HashString(string plaintext, string salt);
    }
}
