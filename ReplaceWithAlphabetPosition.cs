/****
Replace every letter ina given string with its position in the alphabet.
If anything in the text isn't a letter, ignore it and don't return it.
"a" = 1, "b" = 2, etc.
Example
TestReplaceWithAlphabetPosition.AlphabetPosition("The sunset sets at twelve o' clock.")
Should return "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11" (as a string)
****/
using System;
using System.Collections.Generic;

public static class ReplaceWithAlphabetPosition{
    public static void replaceWithAlphabetPosition(string text){
        string outputResult="";
        Dictionary<Char,int> alphabetValue = new Dictionary<Char,int>();
        Char alpha ='A';
        
        //Store the alphabets and its position values in a dictionary.
        for(int i=1; i!=27; i++){      
            alphabetValue.Add(alpha,i);
            alpha++;
        }
        
        //Checks whehter the character in given string is present in the dictionary, If so, get the vakue of the key.
        char[] eachChar = text.ToUpper().ToCharArray();
        foreach(Char letter in eachChar ){
            if(char.IsLetter(letter)){
                if(alphabetValue.ContainsKey(letter)){
                    outputResult = outputResult + alphabetValue[letter].ToString() + " ";
                }
            }
        }
        
        Console.WriteLine(outputResult.TrimEnd());
    }
}
