using System;
using System.Text;

public static class ReverseAString{
    public static void reverse(){
        string str="Hello world";
        
        char[] charr = str.ToCharArray();

        //Using built-in method :
        Array.Reverse(charr);
        foreach(char c in charr){
            Console.Write(c);
        }

        //Using traditional for-loop method to reverse from the last char:
        string op ="";
        for(int i=str.Length-1; i>=0; i--){
            op = op+ str[i];
        }
        Console.WriteLine(op);
    }
}