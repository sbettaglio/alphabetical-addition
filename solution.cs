using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
  public static char AddLetters(char[] letters)
  {
    if (letters.Count() < 1)
    {
      return 'z';
    }
    else
    {
      var alphabet = "abcdefghijklmnopqrstuvwxyz";
      var answer = 'z';

      int sum = 0;
      for (int i = 0; i < letters.Length; i++)
      {
        sum += (alphabet.IndexOf(letters[i]) + 1);
      }
      while (sum > 26)
      {
        sum = sum - 26;
      }

      return alphabet[sum - 1];

    }
  }
}