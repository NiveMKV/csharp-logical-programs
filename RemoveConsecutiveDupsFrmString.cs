using System;
using System.Collections;

public static class RemoveConsecutiveDupsFrmString{
    public static string removeConsecutiveDups(string word= "teesssstyuut"){
        //string givenStr = "teesssstyuut"; //testyut
        
        if (word.Length <= 1) {
            return word;
        }

        if (word.Substring(0,1).Equals(word.Substring(1,2))) {
            return removeConsecutiveDups(word.Substring(0, 1) + word.Substring(2));
        }
        else {
            return word.Substring(0,1) + removeConsecutiveDups(word.Substring(1));
        }
    }
}