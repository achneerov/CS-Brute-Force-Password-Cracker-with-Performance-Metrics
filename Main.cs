using System;
using System.Collections.Generic;  // Add this namespace
using System.Diagnostics;
using System.Linq;
using System.Threading;

class BruteForcePasswordCracker
{
    private static readonly char[] DefaultCharset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
    
    static void Main(string[] args)
    {
        string targetPassword = "aB1"; // Change to test with different passwords
        char[] charset = DefaultCharset; // Customize charset if needed
        int maxPasswordLength = 4; // Maximum password length to test
        int totalCracks = 0; // Tracks the number of combinations tested

        // Start Stopwatch to measure the performance
        Stopwatch stopwatch = Stopwatch.StartNew();

        // Begin brute force search
        string crackedPassword = BruteForceCrack(targetPassword, charset, maxPasswordLength, ref totalCracks);

        // Stop the stopwatch after cracking the password
        stopwatch.Stop();

        // Output the result and performance metrics
        if (crackedPassword != null)
        {
            Console.WriteLine($"Password cracked! The password is: {crackedPassword}");
            Console.WriteLine($"Total combinations tested: {totalCracks}");
            Console.WriteLine($"Cracking time: {stopwatch.Elapsed.TotalSeconds} seconds.");
        }
        else
        {
            Console.WriteLine("Failed to crack the password.");
        }
    }

    // Brute-force algorithm to generate and test all combinations
    private static string BruteForceCrack(string targetPassword, char[] charset, int maxLength, ref int totalCracks)
    {
        for (int length = 1; length <= maxLength; length++)
        {
            foreach (var combination in GetCombinations(charset, length))
            {
                totalCracks++;
                if (new string(combination) == targetPassword)
                {
                    return new string(combination); // Return the cracked password
                }
            }
        }
        return null; // If password is not found
    }

    // Method to generate combinations of characters of a given length
    private static IEnumerable<char[]> GetCombinations(char[] charset, int length)
    {
        int charsetLength = charset.Length;
        char[] result = new char[length];
        for (int i = 0; i < charsetLength; i++)
        {
            result[0] = charset[i];
            if (length == 1)
            {
                yield return result;
            }
            else
            {
                foreach (var next in GetCombinations(charset, length - 1))
                {
                    Array.Copy(next, 0, result, 1, length - 1);
                    yield return result;
                }
            }
        }
    }
}
