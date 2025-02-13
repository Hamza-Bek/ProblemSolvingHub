string LongestCommonPrefix(string[] strs) {

    string prefix = strs[0];        

    for(int i = 1; i < strs.Length; i++)
    {        
        string currentPrefix = string.Empty;
        Console.WriteLine($"Word : {strs[i]}");  
        for(int r = 0 ; r < strs[i].Length; r++)
        {
            if(r >= prefix.Length) break;                

            if(strs[i][r] == prefix[r]) 
            {
                currentPrefix += strs[i][r];                                           
            }                    

            else
            {
                break;                                            
            }                    
        }    
        prefix = currentPrefix;        
    }        
    return prefix;
}

string[] words = { "flower", "flow", "flight" };

var result = LongestCommonPrefix(words);
        
Console.WriteLine("Longest Common Prefix: " + result);