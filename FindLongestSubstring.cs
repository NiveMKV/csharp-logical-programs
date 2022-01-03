public static class FindLongestSubstring{
    public static void findLongestSubstring(){
        string str = "The Quick the brown The fox a jumps A over The a lazy dog";
        string[] splittedString = str.Split(" ");
        var stringsLength = splittedString.Select((ss)=> ss.Length);
        int maxStringLength = stringsLength.Max();
        
        for(int i=0; i<= splittedString.Length -1; i++){
            if(splittedString[i].Length == maxStringLength){
                Console.WriteLine(splittedString[i]);
            }
        }
    }
}