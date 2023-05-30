using System;
using System.Linq;
namespace PalindromeExercise
{
	public class WordSmith
	{
		public bool IsAPalindrome(string word)
		{
			/*word = word.ToLower();
			var reversed = "";

			for(int i = word.Length -1; i >= 0; i--)
			{
				reversed += word[i];
			}

			if(reversed == word)
			{
				return true;
			}
			else
			{
				return false;
			}*/

			word = word.ToLower();
			return word.SequenceEqual(word.Reverse());

		}
		
	}
}

