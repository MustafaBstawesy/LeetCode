public class Solution {
    public int LengthOfLastWord(string s) {

        if(s.Length == 1)
          return 1;
        int Counter = 0;
        s =s.TrimEnd();
        for(int i = s.Length - 1 ; i >= 0 ; i--){
           
           if(s[i] == ' ')
             return Counter;
           Counter++;
        }
        return Counter;
    }
}