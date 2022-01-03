using System;
using System.Collections.Generic;
using System.Linq;

public static class PrintDupCharsInArr{
    public static void PrintDupChars(){
        string givenStr = "HeyyHiiWorlld..";
        char[] chArr = givenStr.ToCharArray();
        List<char> listOfCHars =chArr.ToList();
        
        Dictionary<char,int> dupsCount = new Dictionary<char, int>();

        //Shows duplicates count/ occurences.
        foreach(char i in chArr){
            if(!dupsCount.ContainsKey(i))
                dupsCount.Add(i,1);
            else{
                dupsCount[i] = dupsCount[i]+1;
            }
        }
        foreach(KeyValuePair<char,int> kvp in dupsCount){
            Console.WriteLine($"key : {kvp.Key}  value: {kvp.Value}");
        }
        
        //Prints only the non-duplicate characters:
        /*
        foreach(char i in chArr){
            if(!dupsCount.ContainsKey(i))
                dupsCount.Add(i,1);
        }
        foreach(KeyValuePair<char,int> kvp in dupsCount){
            Console.WriteLine($"the non duplicate values are : {kvp.Key}");
        }
        */


        //Prints only the non-duplicate characters: using LinQ Distinct.
        /*
        IEnumerable<char> nondupLinq = chArr.Distinct();
        foreach(var i in nondupLinq){
            Console.WriteLine(i);
        }
        */

        
        //Removes all the elements that occured more than once.
        /*
        foreach(KeyValuePair<char,int> kvp in dupsCount){
            if(kvp.Value >1){
                listOfCHars.RemoveAll((c)=> c== kvp.Key);
            }
        }
        foreach(var i in listOfCHars){
           Console.WriteLine(i);
        }
        */        
    }
}