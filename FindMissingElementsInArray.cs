using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

public static class FindMissingElementsInArray{
    public static void FindMissing(){
        int[] intArr = new int[] {2,3,3,5};
        int maxN = intArr.Max();
        for(int i=1; i<=maxN; i++){
            if(! Array.Exists(intArr, (x) =>  x == i)){
                Console.WriteLine(i);
            }
        }
    }
}