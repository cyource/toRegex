using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
	
//By Manas Rawat (cyource)

namespace toRegex
{

	public class Program
	{
			public static void Main(string[]args)
			{

				while(true){
				string input = Console.ReadLine();
				List<char>chars = new List<char>();
				List<List<string>> listslist = new List<List<string>>();
				bool validity = false;
		
				foreach (char c in input){
					chars.Add(c);
				}
				
				for (int i = 0; i < chars.Count; i++) {
					char[]regexes = {'d','s'};
					string[] regexes2 = {@"\d",@"\s"};
					
					for (int j = 0; j < 2;j++) { //1s
						if (Regex.IsMatch(chars[i].ToString(), regexes2[j])){ //2s
							
							List<string>strings = new List<string>();
							List<string>strings2 = new List<string>();
							
							string abc = "abcdefghijklmnopqrstuzwxyz";
							
							List<char>xyz = new List<char>();
							foreach (char a in abc){ //3s
								xyz.Add(a);
							} //3e
							
							string chara = (string.Join("",chars.ToArray()).ToLower());
							int count = chara.Count(f => f == ' ');
							
							for (int l = 0; l <= count; l++) { //4s
								
								List<char>mn = new List<char>();
								List<char>nm = new List<char>();
							
								string[] split = Regex.Split(chara,@"(?<=\s)");		
								string splitee = split[l];
								
								List<char> splits = new List<char>();
								foreach (char s in splitee){
									splits.Add(s);
								} 
							
							for (int k = 0; k < 26; k++){ //5s
								if (splits.Contains(xyz[k])){
									mn.Add(xyz[k]);
								} else {
									nm.Add(xyz[k]);
								} 
							}	//5e
							
							String accepted = "";
							String rejected = "";							
							String ar = "";
								
							if (mn.Any())  {
								accepted = "[" + string.Join("",mn.ToArray()) + "]";
								validity = true;
							}
							
							if (nm.Any()) {
								rejected = "[^" + string.Join("",nm.ToArray()) + "]";
							}

							if (string.Join("",splits.ToArray()).Any(char.IsDigit)) {		
								ar = Regex.Replace(string.Join("",splits.ToArray()).ToLower(),@"[a-z]","");
							}
								
							strings.Add(accepted + ar);
							strings2.Add(rejected + ar);
								
							listslist.Add(strings);
							listslist.Add(strings2);
							} //2e
							
							chars.Remove(chars[i]);
							chars.Insert(i, '\\');
							chars.Insert(i+1,regexes[j]);
							
							if (i+2 < chars.Count && Regex.IsMatch(chars[i+2].ToString().ToLower(), @"[a-z]")){
								chars.Insert(i+2, '\\');
							} 
							
						} //4e
						
					} //1e
						
				}	
				
				if (validity){
					string prex = string.Join("",listslist[0].ToArray()); 
					string prex2 = string.Join("",listslist[1].ToArray());
					Console.WriteLine(dashes(prex) + prex + "\n" + dashes(prex2) + prex2);
				}
				
				string regex = "@\"" + string.Join("",chars.ToArray()) + "\"";
				Console.WriteLine(dashes(regex) + regex);
				}
			}
		
		static string dashes(string dashee) {
			
			string dashes = "";
			foreach(char c in dashee){
				dashes+="-";
			}
			dashes+="\n";
			return dashes;
			
		}
	}
}
