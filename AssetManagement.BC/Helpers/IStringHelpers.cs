namespace AssetManagement.BC.Helpers
{
    public interface IStringHelpers
    {
        public string decryptDES(string ciphertextWithIv);
        public string HashString(string plaintext, string salt);
    }
}
