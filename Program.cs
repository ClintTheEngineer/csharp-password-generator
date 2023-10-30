using System;
using System.Collections.Generic;

namespace learn_csharp
{
  class Program
  {
    static void Main()
    {
        Console.WriteLine(Solution());
    }
    
    public static string Solution()
    {
        int passwordLength = int.Parse(Console.ReadLine());
        List<string> alpha = new List<string>() {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
        List<int> nums = new() {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
        List<char> syms = new() {'!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+', '-', '='};
        List<string> upperAlpha = new() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};

        Random random = new();
        List<string> passwordCharacters = new();
        {
          passwordCharacters.AddRange(alpha);
          passwordCharacters.AddRange(nums.ConvertAll(num => num.ToString()));
          passwordCharacters.AddRange(syms.ConvertAll(sym => sym.ToString()));
          passwordCharacters.AddRange(upperAlpha);
        };

        string password = "";
        for(int i = 0; i < passwordLength; i++)
        {
          int randomIndex = random.Next(0, passwordCharacters.Count);
          password += passwordCharacters[randomIndex];
        }
        return password;
    }
    
  }
  
}
