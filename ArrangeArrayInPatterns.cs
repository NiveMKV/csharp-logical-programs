/**
Arrange the given array of values {0,0,1,3,0,1,1,3,1,3,0,2,2} to like this output = {0,0,0,0,1,1,1,1,2,2,3,3,3}
**/

using System;
using System.Collections.Generic;
using System.Linq;

public static class ArrangeArrayInPatterns{
    
    public static void Arrange(){
        int[] givenIntArr = {0,0,1,3,0,1,1,3,1,3,0,2,2}; 
        int[] copyArray = new int[givenIntArr.Length];
        givenIntArr.CopyTo(copyArray,0);
        IEnumerable<int> distinctArr =copyArray.Distinct();
        List<int> opList = new List<int>();
        
        //Can use Linq query to fill-in the List.
        // foreach(int d in distinctArr){
        //     var op = from arrs in givenIntArr
        //     where arrs == d
        //     select arrs;
        //     foreach(var i in op){
        //         opList.Add(i);
        //     }            
        // }
        
        //Can use Array Class to fill-in the List.
        foreach(int d in distinctArr){
            int[] a = Array.FindAll(givenIntArr, (x)=> x == d)   ;
            foreach(var i in a){
                opList.Add(i);
            }          
        }
        opList.Sort(); 
        Console.WriteLine(string.Join(',', opList));
        
    }
}