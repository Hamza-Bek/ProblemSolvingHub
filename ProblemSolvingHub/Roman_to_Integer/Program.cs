string s = "MCMXCIV";

Dictionary<char , int>romanDic = new Dictionary <char , int> {
    { 'I', 1 },
    { 'V', 5 },
    { 'X', 10 },
    { 'L', 50 },
    { 'C', 100 },
    { 'D', 500 },
    { 'M', 1000 }
};        

int sum = 0;

for(int i = 0; i < s.Length -1; i++)
{
    char currentChar = s[i];
    char nextChar = s[i + 1];
            
    //GET THE VALUE OF THE PASSING CHAR
    if(romanDic.TryGetValue(currentChar , out int value) && romanDic.TryGetValue(nextChar, out int nextValue))
    {                    
        if(value < nextValue) 
        {                   
            sum -= value ;                        
        }
                
        else if(value >= nextValue){
            sum += value;                    
        }
    }
}

if (romanDic.TryGetValue(s[^1], out int lastValue))
{
    sum += lastValue;         
}

Console.WriteLine(sum);
return sum;