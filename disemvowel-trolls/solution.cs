using System;

public static class Kata
{
    public static string Disemvowel(string str)
    {
        char[] vowels = new char[10] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };

        foreach (var character in str)
          {
            if (Array.Exists(vowels, vowel => vowel == character))
              {
                str = str.Remove(str.IndexOf(character), 1);
              }
          }

        return str;
    }
}