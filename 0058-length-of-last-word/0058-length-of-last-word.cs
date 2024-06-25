public class Solution {
    public int LengthOfLastWord(string s) {

        if(s.Length == 1)
          return 1;
        s =s.TrimEnd();
       
        int i = 0;
        for( i = s.Length - 1 ; i >= 0 ; i--){
           
           if(s[i] == ' ')
             return (s.Length - i) -1;
        }
        return (s.Length - i) - 1;
    }
}