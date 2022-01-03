using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

public class PrintRangeWithoutLoop{
    public void PrintRange(){
        List<int> list= Enumerable.Range(1,20).ToList<int>();
        string str = string.Join(",", list.Select(n => n.ToString()));
        //string str = string.Join(",", list.Where(n => n%2 ==0));
        List<int> lst = list.FindAll((n)=> n%2 == 0);
        foreach(var i in lst){
            Console.WriteLine(i);
        }
        Console.WriteLine(str);
    }
}
