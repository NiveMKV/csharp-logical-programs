using System;
using System.Text.RegularExpressions;

public static class DetectPangram{
    public static void detectPangram(string str){
        string alphaNumericString   = Regex.Replace(str, @"\W+", string.Empty,RegexOptions.Multiline);
        string alphabetsString      = Regex.Replace(alphaNumericString, @"\d+", string.Empty,RegexOptions.Multiline);
        char[] eachChar             = alphabetsString.ToLower().ToCharArray();
        List<char> opList           = new List<char>();
        
        for(int count=0; count<eachChar.Length; count++){
            if(!opList.Contains(eachChar[count])){
                opList.Add(eachChar[count]);  
            }
        }
        if(opList.Count == 26)
            Console.WriteLine("Its a Pangram!!!...");
        else 
            Console.WriteLine("Its not a Pangram!!!...");
    }
}