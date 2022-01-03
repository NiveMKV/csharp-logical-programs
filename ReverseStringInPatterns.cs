/*
The output be "l ri gmai" for input : "I am Girl".
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
public static class ReverseStringInPatterns{

    public static void ReverseStringInPattern(){
        string givenStr = "I am Girl"; 

        var reversedStr = givenStr.Reverse();
        string revStr = string.Empty;
        foreach(var s in reversedStr){
            Console.WriteLine(s);
            revStr = revStr + s;
        }
        // string a = new string(reversedStr);
        // a.Replace(" ","");
        string revStrWithoutSpace = revStr.Replace(" ","");
        string[] spltStr = givenStr.Split(" ");
        StringBuilder opStr = new StringBuilder();
        int revStrIndexCount = 0;
        foreach(string s in spltStr)
        {
            int count = s.Length;
            while(count!=0){
                opStr.Append(revStrWithoutSpace[revStrIndexCount]);
                count --;
                revStrIndexCount ++;
            }
            opStr.Append(" ");
        }
        Console.WriteLine(opStr);

    }
}