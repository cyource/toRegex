using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
	
namespace exclusiveToRegex
{

	class Program
	{
		static void Main(string[]args)
		{

			string input;
			while (true) {
			input = Console.ReadLine();
			List<char>chars = new List<char>();
		
			foreach (char c in input){
				chars.Add(c);
			}
				
			for (int i = 0; i < chars.Count; i++) {
				char[]regexes = {'d','s'};
				string[] regexes2 = {@"\d",@"\s"};
					
				for (int k = 0; k < regexes.Length;k++) {
					if (Regex.IsMatch(chars[i].ToString(), regexes2[k])){
						chars.Remove(chars[i]);
						chars.Insert(i, '\\');
						chars.Insert(i+1,regexes[k]);
						
						if (i+3 < chars.Count && Regex.IsMatch(chars[i+2].ToString(), @"\w") 
						&& Regex.IsMatch(chars[i+2].ToString(), @"\d|\s").Equals(false)){
							chars.Insert(i+2, '\\');
							chars.Insert(i+3, '\\');
						}
							
						/*if (i+3 <= chars.Count && chars[i] == '\\' && chars[i+1] == 'd' && chars[i]==chars[i+2] && chars[i+1]==chars[i+3]) {
							chars.Remove(chars[i+2]);
							chars.Remove(chars[i+3]);
							chars.Insert(i+2,'+');
						}*/
						} 
						
					}
						
				}	
				
				//string[] toShow = {string.Join("",chars.ToArray()), "\\\\"+ input};	
				
				Console.WriteLine("@\"" + string.Join("",chars.ToArray()) + "\"");

		
			}
		}
	}
}
