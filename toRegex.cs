using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
	
namespace toRegex
{

	class Program
	{
			static void Main(string[]args)
			{

				string input;
				//while (true) {
				input = Console.ReadLine();
				List<char>chars = new List<char>();
				List<char>chars2 = new List<char>();
				List<string>strings = new List<string>();
				List<string>strings2 = new List<string>();
		
				foreach (char c in input){
					chars.Add(c);
					chars2.Add(c);
				}
				
				for (int i = 0; i < chars.Count; i++) {
					char[]regexes = {'d','s'};
					string[] regexes2 = {@"\d",@"\s"};
					
					for (int j = 0; j < regexes.Length;j++) {
						if (Regex.IsMatch(chars[i].ToString(), regexes2[j])){
							chars.Remove(chars[i]);
							chars.Insert(i, '\\');
							chars.Insert(i+1,regexes[j]);
							
							if (i+3 < chars.Count && Regex.IsMatch(chars[i+2].ToString(), @"\w") 
								&& Regex.IsMatch(chars[i+2].ToString(), @"\d|\s").Equals(false)){
								chars.Insert(i+2, '\\');
								chars.Insert(i+3, '\\');
							}
							
							string abc = "abcdefghijklmnopqrstuzwxyz";
							List<char>xyz = new List<char>();
							foreach (char a in abc){
								xyz.Add(a);
							}
							
							string chara = string.Join("",chars2.ToArray());
							int count = chara.Split(' ').Length - 1;
							
							for (int l = 0; l <= count; l++) {
								
								List<char>mn = new List<char>();
								List<char>nm = new List<char>();
							
								string[] split = chara.Split(' ');		
								string splitee = split[l];
								
								List<char> splits = new List<char>();
								foreach (char s in splitee){
									splits.Add(s);
								}
							
							for (int k = 0; k < 26; k++){
								if (splits.Contains(xyz[k])){
									mn.Add(xyz[k]);
								} else if (splits.Contains(xyz[k]).Equals(false)){
									nm.Add(xyz[k]);
								}
							}	
								
							String accepted = "[" + string.Join("",mn.ToArray()) + "]";
							String rejected = "[^" + string.Join("",nm.ToArray()) + "]";

							String ar = Regex.Replace(string.Join("",chars.ToArray()),@"\w","");
							String r = Regex.Replace(string.Join("",chars.ToArray()),@"\w","");
							strings.Add(accepted + ar);
							strings2.Add(rejected + r);
							}
																			
							Console.WriteLine(string.Join("",strings.ToArray()));
							Console.WriteLine(string.Join("",strings2.ToArray()));
						} 
						
					}
						
				}	
					
					Console.WriteLine("@\"" + string.Join("",chars.ToArray()) + "\"");

		
			}
	}
}
