using System;
using System.Linq;

namespace WinFormsApp6;
public class PalindromeChecker
{
    public string FromUser { get; private set; }

    public PalindromeChecker(string fromUser)
    {
        if (string.IsNullOrWhiteSpace(fromUser))
        {
            throw new ArgumentException("Введенне не повинно бути порожнім в текстовому полі або складатися лише з пробілів.");
        }
        FromUser = fromUser;
    }

    public bool IsPalindrome()
    {
        string cleanedWord = new string(FromUser
                                        .Where(char.IsLetterOrDigit)
                                        .Select(char.ToLower)
                                        .ToArray());

        return cleanedWord.SequenceEqual(cleanedWord.Reverse());
    }
}