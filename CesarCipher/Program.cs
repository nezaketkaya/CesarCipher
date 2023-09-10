using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.Write("Enter your message: ");
            string secretMsg = Console.ReadLine(); // Corrected capitalization

            char[] secretMessage = secretMsg.ToCharArray();
            int n = secretMessage.Length; // Corrected variable declaration and capitalization
            char[] encryptedMessage = new char[n];
            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];
                int letterPosition = Array.IndexOf(alphabet, letter);
                if (letterPosition != -1) // Check if the character is in the alphabet array
                {
                    int newLetterPosition = (letterPosition + 3) % 26; // Add 3 and wrap around if needed
                    char letterEncoded = alphabet[newLetterPosition];
                    encryptedMessage[i] = letterEncoded;
                }
                else
                {
                    encryptedMessage[i] = letter; // If it's not a letter, keep it unchanged
                }
            }
            string msgString = new string(encryptedMessage);
            Console.WriteLine("Encrypted message: " + msgString); // Corrected variable name
        }
    }
}


