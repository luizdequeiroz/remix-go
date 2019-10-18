using System.Security.Cryptography;
using System.Text;

namespace service.Utilities
{
    public class CryptoUtility
    {
        private HashAlgorithm hashAlgorithm;

        public CryptoUtility()
        {
            this.hashAlgorithm = SHA512.Create();
        }

        public CryptoUtility(HashAlgorithm hashAlgorithm)
        {
            this.hashAlgorithm = hashAlgorithm;
        }

        public string EncryptPassword(string password)
        {
            var encodedValue = Encoding.UTF8.GetBytes(password);
            var encryptedPassword = hashAlgorithm.ComputeHash(encodedValue);
            var sb = new StringBuilder();
            foreach (var caracter in encryptedPassword)
            {
                sb.Append(caracter.ToString("X2"));
            }

            return sb.ToString();
        }

        public bool VerifyPassword(string passwordTyped, string passwordRegistered)
        {
            if (string.IsNullOrEmpty(passwordTyped))
                return false;

            if (string.IsNullOrEmpty(passwordRegistered))
                return false;

            var hashPasswordTyped = EncryptPassword(passwordTyped);

            return hashPasswordTyped.Equals(passwordRegistered);
        }
    }
}
