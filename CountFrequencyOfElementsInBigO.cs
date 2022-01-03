/*
int variable = new int[] {2,3,3,5}; Count the frequency of the elements in the array and also the missing elements' frequencies 
upto the maximum number of the element in the array.
*/
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
//time complexity = 
public static class CountFrequencyOfElementsInBigO{
    public static void PrintFrequency(int[] arr){
        Dictionary<int, int> freqDict = new Dictionary<int, int>();
        int maxValue = arr.Max();

        for(int i=1; i<= maxValue; i++){
            freqDict.TryAdd(i, Array.FindAll( arr, (x) => x == i).Count());
        }

        foreach(KeyValuePair<int,int> kvp in freqDict){
            Console.WriteLine($" key is {kvp.Key} and the freq is {kvp.Value} ");
        }
    }
}