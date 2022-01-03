using System;
using System.Collections.Generic;
using System.Linq;

public static class PrintNthLargestNumberInArray{
    private static void PrintAnyLargestNum(int n){
        int[] givenIntArr = {30,45,31,18,4, 60};
        Array.Sort(givenIntArr);
        int desiredNum = givenIntArr.Length - n;
        Console.WriteLine(givenIntArr[desiredNum]);
    }
    public static void print(){
        PrintAnyLargestNum(2);
    }
    
}