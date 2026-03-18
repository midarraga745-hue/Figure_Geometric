namespace Evaluator.Core;

public class ExpressionEvaluator
{
    public static double Evaluate(string infix)
    {
        var postfix = InfixToPostfix(infix);
        return Calculate(postfix);
    }

    // Divide the espression into tokens(numbers and operators)
    private static List<string> Tokenize(string expression)
    {
        var tokens = new List<string>();
        var number = string.Empty;

        foreach (char item in expression)
        {
            if (IsOperator(item))
            {
                if (number != string.Empty)
                {
                    tokens.Add(number);
                    number = string.Empty;
                }
                tokens.Add(item.ToString());
            }
            else // is digit or decimal point
            {
                number += item;
            }
        }

        if (number != string.Empty)
            tokens.Add(number);

        return tokens;
    }

    private static string InfixToPostfix(string infix)
    {
        var stack = new Stack<string>();
        var postfix = new List<string>();
        var tokens = Tokenize(infix);

        foreach (string token in tokens)
        {
            if (token.Length == 1 && IsOperator(token[0]))
            {
                char op = token[0];
                if (op == ')')
                {
                    while (stack.Peek() != "(")
                        postfix.Add(stack.Pop());
                    stack.Pop();
                }
                else if (op == '(')
                {
                    stack.Push(token);
                }
                else
                {
                    while (stack.Count > 0 && stack.Peek() != "(" &&
                           PriorityInfix(op) <= PriorityStack(stack.Peek()[0]))
                    {
                        postfix.Add(stack.Pop());
                    }
                    stack.Push(token);
                }
            }
            else // It's a number
            {
                postfix.Add(token);
            }
        }

        while (stack.Count > 0)
            postfix.Add(stack.Pop());

        return string.Join(" ", postfix);
    }

    private static bool IsOperator(char item) => item is '^' or '/' or '*' or '%' or '+' or '-' or '(' or ')';

    private static int PriorityInfix(char op) => op switch
    {
        '^' => 4,
        '*' or '/' or '%' => 2,
        '-' or '+' => 1,
        '(' => 5,
        _ => throw new Exception("Invalid expression."),
    };

    private static int PriorityStack(char op) => op switch
    {
        '^' => 3,
        '*' or '/' or '%' => 2,
        '-' or '+' => 1,
        '(' => 0,
        _ => throw new Exception("Invalid expression."),
    };

    private static double Calculate(string postfix)
    {
        var stack = new Stack<double>();
        var tokens = postfix.Split(' ');

        foreach (string token in tokens) // <-- Foreach modified
        {
            if (token.Length == 1 && IsOperator(token[0]))
            {
                var op2 = stack.Pop();
                var op1 = stack.Pop();
                stack.Push(Calculate(op1, token[0], op2));
            }
            else
            {
                stack.Push(double.Parse(token)); // Supports 123, 3.14, etc.
            }
        }

        return stack.Peek();
    }

    private static double Calculate(double op1, char item, double op2) => item switch
    {
        '*' => op1 * op2,
        '/' => op1 / op2,
        '^' => Math.Pow(op1, op2),
        '+' => op1 + op2,
        '-' => op1 - op2,
        _ => throw new Exception("Invalid expression."),
    };
}