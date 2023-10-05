namespace MatchingBracketsConsoleApp
{
    public class MatchingBrackets
    {
        public bool HasMatchingBrackets(string input)
        { 
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '<')
                {
                    count++;
                }
                else if (input[i] == '>')
                {
                    count--;
                    if (count < 0) return false;
                }
            }
            return count == 0;
        }

    }
}
