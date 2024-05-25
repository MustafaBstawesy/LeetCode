public class Solution {
    public bool IsPalindrome(int x) 
    {
        string Number = x.ToString();
        StringBuilder sbReverced = new StringBuilder();
        short Index = 0;
        
        for (int i = Number.Length - 1 ; i >= 0 ; i--)
        {
            sbReverced.Insert(Index, Number[i]);
            Index++;
        }
         
        return (Number == sbReverced.ToString());
    }
}