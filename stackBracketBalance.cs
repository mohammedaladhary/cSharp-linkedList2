using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_linked_lists
{
    internal class stackBracketBalance
    {
        private Stack<char> bracket;
        private Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
    {
        { '(', ')' },
        { '{', '}' },
        { '[', ']' }
    };

        internal bool IsBalanced(string exp, out string explanation)
        {
            bracket = new Stack<char>();
            explanation = "";

            foreach (char bt in exp)
            {
                if (bracketPairs.ContainsKey(bt))
                {
                    bracket.Push(bt);
                }
                else if (bracketPairs.ContainsValue(bt))
                {
                    if (bracket.Count == 0)
                    {
                        explanation = $"There is a closing '{bt}' without a corresponding opening bracket.";
                        return false; // matching failed because of no opening bracket
                    }
                    char lastOpeningBracket = bracket.Pop();
                    if (!bracketPairs.TryGetValue(lastOpeningBracket, out char expectedClosingBracket) || expectedClosingBracket != bt)
                    {
                        explanation = $"There is a closing '{bt}' before the corresponding opening '{lastOpeningBracket}'.";
                        return false; // Mismatched brackets
                    }
                }
            }

            if (bracket.Count > 0)
            {
                char unmatchedBracket = bracket.Pop();
                explanation = $"There is an unclosed opening '{unmatchedBracket}'.";
                return false; // Unbalanced brackets
            }
            explanation = "all the brackets are well-formed";
            return true; // Balanced brackets
        }
    }
}
