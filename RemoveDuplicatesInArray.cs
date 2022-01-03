/*
// print only elements appeared only once
// remove elements appeared more than once.
// remove duplicate elements.
*/

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

public static class RemoveDuplicatesInArray{
    public static void removeDuplicate(){
        int[] arr1 = new int[]{ 7, 7, 8, 8, 9, 1, 1, 4, 2, 2 };
        List<int> lst = new List<int>();
        
        //To have only unique elements in an array.
        //Can also use dictionary to store only unique elements by using condition that if the element already present skip adding to the dictionary.
        var dis = arr1.Distinct();
        Console.WriteLine(string.Join(",", dis));

        //To remove all the elements that occurred more than once.
        List<int> arrLst = arr1.ToList<int>();
        Dictionary<int, int> intDupsCount = new Dictionary<int, int>();
        foreach(int item in arrLst){
            if(!intDupsCount.ContainsKey(item)){
                intDupsCount.Add(item, 1);
            }else{
                intDupsCount[item] = intDupsCount[item]+1;
            }
        }
        foreach(KeyValuePair<int,int> kvp in intDupsCount){
            if(kvp.Value >1 ){
                arrLst.RemoveAll((i) => i == kvp.Key);
            }
        }
        foreach(var l in arrLst){
            Console.WriteLine(l);
        }        
    }
}
