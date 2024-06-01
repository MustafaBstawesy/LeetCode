public class Solution {

 public bool IsValid(string s){

      Stack<char> openingParentheses = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')       
                openingParentheses.Push(c);
            else
            {
                if (openingParentheses.Count == 0) return false;
                var opening = openingParentheses.Pop();

                if (opening == '(' && c != ')'
                    || opening == '{' && c != '}'
                    || opening == '[' && c != ']')  return false;
            }
        }
        return !(openingParentheses.Count > 0);
 }

}