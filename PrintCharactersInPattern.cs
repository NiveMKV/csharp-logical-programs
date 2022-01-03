using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

public static class PrintCharactersInPattern{
    public static void PrintCharactersInSequence(){
        string givenString = "A2B3C4";
        Dictionary<char, char> dict = new Dictionary<char, char>();
        
        for(int i=0; i<givenString.Length; i++){
            for(int j=i+1; j==i+1; j++){
                dict.Add(givenString[i], givenString[j]);
            }
            i++;            
        }
        foreach(KeyValuePair<char,char> kvp in dict){
            Console.WriteLine($"key is {kvp.Key} and val is {kvp.Value}");
        }
        
        string op="";
        foreach(KeyValuePair<char,char> kvp in dict){
            // int count= Convert.ToInt32(kvp.Value); //gives the ASCII code
            int count = kvp.Value - '0';
            Console.WriteLine(count);
            while(count !=0){
                op= op + kvp.Key;
                count--;
            }
        }
        Console.WriteLine(op);
    }
}