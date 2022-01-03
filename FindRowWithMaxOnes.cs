using System;
using System.Collections.Generic;
using System.Linq;

public static class FindRowWithMaxOnes{
    public static void maxOnes(){
        int[,] givenArr = new int[,] {{0,1,1,1}, {0,0,1,1}, {1,1,1,1}, {0,0,0,0}};
        int maxCount=0;
        int maxCountIndex =0;
        Console.WriteLine((givenArr.Length).ToString());
        for(int i=0; i< 4; i++){
            int count=0;
            for(int j=0; j<4; j++){                
                if(givenArr[i,j] == 1){
                    count++;
                }                
            }
            if(count > maxCount){
                maxCount = count;
                maxCountIndex =i;
            }
        }    
        Console.WriteLine(maxCountIndex.ToString())    ;
    }
}