using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
	
namespace cyource_console_project 
{

	public class toRegex
	{
			public static void Main()
			{
				Console.WriteLine("a");
				string input = Console.ReadLine();
				List<char>chars = new List<char>();
		
				foreach (char c in input){
					chars.Add(c);
				}
				
				for (int i = 0; i < chars.Count; i++) {
					char[]regexes = {'d','s'};
					string[] regexes2 = {@"\d",@"\s"};
					for (int k = 0; k <regexes.Length;k++) {
						if (Regex.IsMatch(chars[i].ToString(), regexes2[k])){
							chars.Remove(chars[i]);
							chars.Insert(i, '\\');
							chars.Insert(i+1,regexes[k]);
						}
					}
				}
				
				/*for (int j = 0; j< chars.Count; j++){
					if (j < chars.Count && chars[j].Equals(chars[j+2]) && chars[j+1].Equals(chars[j+3])) {
						chars.Remove(chars[j+2]);
						chars.Remove(chars[j+3]);
						chars.Insert(j+2,'+');
					}
				}*/
				
				Console.WriteLine("@\"" + string.Join("",chars.ToArray()) + "\"");
		
			}

	}
}
