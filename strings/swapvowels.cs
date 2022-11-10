using System;

class REVERSEVOWEL
{

	static bool isVowel(char v)
	{
		return (v == 'a' || v == 'A' || v == 'e'
				|| v == 'E' || v == 'i' || v == 'I'
				|| v == 'o' || v == 'O' || v == 'u'
				|| v == 'U');
	}

	static String reverseVowel(String str1)
	{
		int j = 0;

		char[] str = str1.ToCharArray();
		String vowel = "";
		for (int i = 0; i < str.Length; i++)
		{
			if (isVowel(str[i]))
			{
				j++;
				vowel += str[i];
			}
		}
        
		for (int i = 0; i < str.Length; i++)
		{
			if (isVowel(str[i]))
			{
				str[i] = vowel[--j];
			}
		}

		return String.Join("",str);
	}
	public static void Main(String[] args)
	{
		String str = "hello world";
		Console.WriteLine(reverseVowel(str));
	}
}
