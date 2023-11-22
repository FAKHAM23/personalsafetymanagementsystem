using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WomanSafety.BL
{
    public class PasswordHasher
    {
        private const int SaltSize = 16; // 16 bytes for the salt
        private const int HashSize = 20; // 20 bytes for the hash
        private const int Iterations = 10000; // Number of iterations for the key derivation function

        public static string HashPassword(string password)
        {
            // Generate a random salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);

            // Hash the password with the salt using PBKDF2
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations);
            byte[] hash = pbkdf2.GetBytes(HashSize);

            // Combine the salt and password hash
            byte[] hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            // Convert the combined salt and hash to Base64 for storage
            string hashedPassword = Convert.ToBase64String(hashBytes);

            return hashedPassword;
        }

        public static bool VerifyPassword(string storedHashedPassword, string enteredPassword)
        {
            // Convert the stored salted password from Base64
            byte[] hashBytes = Convert.FromBase64String(storedHashedPassword);

            // Extract the salt
            byte[] salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);

            // Compute the hash of the entered password using the stored salt
            var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, Iterations);
            byte[] enteredHash = pbkdf2.GetBytes(HashSize);

            // Compare the computed hash with the stored hash
            for (int i = 0; i < HashSize; i++)
            {
                if (enteredHash[i] != hashBytes[i + SaltSize])
                    return false;
            }

            return true;
        }
    }
}
