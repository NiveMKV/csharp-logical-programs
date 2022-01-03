
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
//time complexity = 
public static class PerformAdditionInLinkedList{
    public static void AddNumberFromTwoLinkedLists(){
        LinkedList<int> ll1= new LinkedList<int>();
        LinkedListNode<int> firstNode = ll1.AddFirst(9);
        ll1.AddAfter(firstNode, 5);
        ll1.AddLast(7);

        LinkedList<int> ll2= new LinkedList<int>();
        ll2.AddFirst(6);
        ll2.AddLast(7);

        Stack<int> s1 = new Stack<int>(ll1);
        Stack<int> s2 = new Stack<int>(ll2);
        Stack<int?> s3 = new Stack<int?>();

        int? carry = 0;
        int? sum =0, op =0;//957, 67 ==> 1024
        string finalOP = "";
        
        while(s1.Count() !=0 || s2.Count() != 0){
            sum = carry + ((s1.TryPop(out int s1R)) ? s1R : s1R) + ((s2.TryPop(out int s2R)) ? s2R : s2R);
            carry = sum/10;
            op = sum%10;
            s3.Push(op);
        }
        if(carry != null){
            s3.Push(carry);
        }
        
        while(s3.Count() !=0){
            finalOP = finalOP + String.Join(",", s3.Pop().ToString());            
        }
        Console.WriteLine(finalOP);
    }
}