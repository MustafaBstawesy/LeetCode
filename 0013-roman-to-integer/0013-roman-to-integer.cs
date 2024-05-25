public class Solution {
    readonly Dictionary<char, int> RomanSymbols = new Dictionary<char, int>()
{
    { 'I', 1 },
    { 'V', 5 },
    { 'X', 10 },
    { 'L', 50 },
    { 'C', 100 },
    { 'D', 500 },
    { 'M', 1000 }
};

public int RomanToInt(string s)
{
    int RomanToInterger = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if(i == s.Length - 1)
            RomanToInterger += RomanSymbols[s[i]];

        else if (RomanSymbols[s[i]] < RomanSymbols[s[i+1]])
        {
            RomanToInterger += RomanSymbols[s[i+1]] - RomanSymbols[s[i]];
            i++;
        }
        else
            RomanToInterger += RomanSymbols[s[i]];
    }
    return RomanToInterger;
}  
}