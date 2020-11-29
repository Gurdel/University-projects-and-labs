using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mini_excel_lab2
{
    public class Parser
    {
        enum Types {NONE, DELIMITER, NUMBER};
        string s = "";
        string exp; //рядок виразу
        int expIdx;
        string token;
        Types tokType;
        public string str_error = "";
        public Parser()
        {

        }

        public double ExpressionStart(string expstr)
        {
            if(expstr == "")
            {
                return 0.0;
            }
            double result;
            exp = expstr;
            int l = exp.Length;
            if(    exp[l - 1].Equals('+') || exp[l - 1].Equals('-') || exp[l - 1].Equals('/')
                || exp[l - 1].Equals('*') || exp[l - 1].Equals('%') || exp[l - 1].Equals('|')
                || exp[l - 1].Equals('^') || exp[l - 1].Equals('>') || exp[l - 1].Equals('<'))
            {
                MessageBox.Show("Last lex should be expression");
                str_error = "Last lex should be expression";
            }
            expIdx = 0;
            try
            {
                GetToken();
                if(token == "")
                {
                    MessageBox.Show("no expression");
                    str_error = "no expression";
                    return 0.0;
                }
                ExpPorivn(out result);
                if(token != "")
                {
                    MessageBox.Show("Last lex  = 0");
                }
                return result;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0.0;
            }
        }
        void Expr(out double result)
        {
            int varIdx;
            Types ttokType;
            string temptoken;
            ExpPorivn(out result);
        }
        void ExpPorivn(out double result)
        {
            string op;
            double partialResult;

            ExpPlusMin(out result);
            while((op = token) == ">" || op == "<")
            {
                GetToken();
                ExpPlusMin(out partialResult);
                switch (op)
                {
                    case ">":
                        if (result > partialResult) result = 1.0;
                        else result = 0.0;
                        break;
                    case "<":
                        if (result < partialResult) result = 1.0;
                        else result = 0.0;
                        break;
                }
            }
        }
        void ExpPlusMin(out double result)
        {
            string op;
            double partialResult;
            ExpMultdiv(out result);
            while ((op = token) == "+" || op == "-")
            {
                GetToken();
                ExpMultdiv(out partialResult);
                switch (op)
                {
                    case "-":
                        result -= partialResult;
                        break;
                    case "+":
                        result += partialResult;
                        break;
                }
            }
        }
        void ExpMultdiv(out double result)
        {
            string op;
            double partialResult = 0.0;
            ExpStepin(out result);
            while((op = token) == "*" || op =="/" || op == "%")
            {
                GetToken();
                ExpStepin(out partialResult);
                switch(op)
                {
                    case "|":
                        if(partialResult == 0.0)
                        {
                            MessageBox.Show("div by zero");
                            str_error = "invalid expression";
                        }
                        else
                        {
                            result = (int)(result) / (int)(partialResult);
                        }
                        break;
                    case "*":
                        result *= partialResult;
                        break;
                    case "/":
                        if(partialResult == 0.0)
                        {
                            MessageBox.Show("div bu zero");
                            str_error = "invalid expression";
                        }
                        else
                        {
                            result /= partialResult;
                        }
                        break;
                    case "%":
                        if (partialResult == 0.0)
                        {
                            MessageBox.Show("div bu zero");
                            str_error = "invalid expression";
                        }
                        else
                        {
                            result = (int)result % (int)partialResult;
                        }
                        break;
                }          
            }
        }
        void ExpStepin(out double result)
        {
            double partialResult, ex;
            int t;
            ExpUnar(out result);
            if(token  == "^")
            {
                GetToken();
                ExpStepin(out partialResult);
                ex = result;
                if(partialResult == 0.0)
                {
                    result = 1.0;
                    return;
                }
                for(t = (int)partialResult -1; t> 0;t--)
                {
                    result *= ex;
                }
            }
        }
        void ExpUnar(out double result)
        {
            string op;
            op = "";
            if((tokType == Types.DELIMITER) && token == "+" || token =="-")
            {
                op = token;
                GetToken();
            }
            ExpBracket(out result);
            if (op == "-")
                result = -1 * result;
        }
        void ExpBracket(out double result)
        {
            if (token == "(")
            {
                GetToken();
                ExpPorivn(out result);
                if (token != ")")
                {
                    MessageBox.Show("Unbalanced parens");
                    str_error = "invalid expression";
                }
                GetToken();
            }
            else Atom(out result);
        }
        void Atom(out double result)
        {
            switch(tokType)
            {
                case Types.NUMBER:
                    try
                    {
                        result = Double.Parse(token);
                    }
                    catch(FormatException)
                    {
                        result = 0.0;
                        MessageBox.Show("Syntax error");
                        str_error = "syntax error";
                    }
                    GetToken();
                    return;
                default:
                    result = 0.0;
                    break;
            }
        }
        void GetToken()
        {
            tokType = Types.NONE;
            token = "";
            if(expIdx == exp.Length)
            {
                return;
            }
            while (expIdx < exp.Length && Char.IsWhiteSpace(exp[expIdx])) ++expIdx;
            //хвіст
            if (expIdx == exp.Length)
            {
                return;
            }
            if (IsDelim(exp[expIdx]))
            {
                token += exp[expIdx];
                expIdx++;
                tokType = Types.DELIMITER;
            }
            else if(Char.IsDigit(exp[expIdx]))
            {
                while(Char.IsDigit(exp[expIdx]))
                {
                    token += exp[expIdx];
                    expIdx++;
                    if (expIdx >= exp.Length) break;
                }
                tokType = Types.NUMBER;
            }
        }

        bool IsDelim(char c)
        {
            if ("+-/*%^|()<>".IndexOf(c) != -1)
                return true;
            return false;
        }
    }

}
