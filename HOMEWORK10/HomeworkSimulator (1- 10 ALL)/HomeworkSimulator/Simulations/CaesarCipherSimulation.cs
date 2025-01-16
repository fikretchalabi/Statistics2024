using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkSimulator.Simulations
{
    public class CaesarCipherSimulation
    {
        public string Encrypt(string text, int shift)
        {
            return new string(text.Select(ch =>
            {
                if (char.IsLetter(ch))
                {
                    char baseChar = char.IsUpper(ch) ? 'A' : 'a';
                    return (char)((ch - baseChar + shift) % 26 + baseChar);
                }
                return ch; // Non-letters are not shifted
            }).ToArray());
        }

        public string Decrypt(string text, int shift)
        {
            return Encrypt(text, 26 - shift); // Decrypt is reverse of encryption
        }

        public int DetectShiftUsingFrequencyAnalysis(string text)
        {
            var frequency = CalculateFrequencyDistribution(text);
            char mostFrequentEncrypted = frequency.OrderByDescending(kvp => kvp.Value).First().Key;

            // Assuming 'e' is the most frequent letter in English text
            return (mostFrequentEncrypted - 'e' + 26) % 26;
        }

        private Dictionary<char, double> CalculateFrequencyDistribution(string text)
        {
            var frequency = new Dictionary<char, int>();
            int totalLetters = 0;

            foreach (char ch in text.ToLower())
            {
                if (char.IsLetter(ch))
                {
                    if (!frequency.ContainsKey(ch))
                    {
                        frequency[ch] = 0;
                    }
                    frequency[ch]++;
                    totalLetters++;
                }
            }

            return frequency.ToDictionary(kvp => kvp.Key, kvp => (double)kvp.Value / totalLetters);
        }
    }
}
