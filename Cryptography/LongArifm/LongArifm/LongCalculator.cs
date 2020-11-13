using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongArifm
{
    class LongCalculator
    {
        int LENGTH = 9;
        int MAX = 1000000000;

        private List<int> getList(string s)
        {
            List<int> res = new List<int>();
            bool zn = false;
            if (s[0] == '-')
            {
                zn = true;
                s = s.Remove(0, 1);
            }
            while (s.Length >= LENGTH)
            {
                res.Add(Convert.ToInt32(s.Substring(s.Length - LENGTH, LENGTH)));
                s = s.Remove(s.Length - LENGTH, LENGTH);
            }
            if (s.Length > 0)
                res.Add(Convert.ToInt32(s));
            res.Reverse();
            if (zn) res[0] *= (-1);
            return res;
        }

        private string outString(List<int> r)
        {
            int l = r.Count();
            string res = r[0].ToString();
            string buf = "";
            for (int i = 1; i < l; ++i)
            {
                buf = r[i].ToString();
                if (buf.Length < LENGTH)
                {
                    for (int j = LENGTH - buf.Length; j > 0; --j)
                        res += "0";
                }
                res += buf;
            }
            return res;
        }

        public bool More(string a, string b)
        {
            if (Equal(a, b)) return false;

            bool za = true;
            bool zb = true;

            if (a[0] == '-') { za = false; a = a.Remove(0, 1); }
            if (b[0] == '-') { zb = false; b = b.Remove(0, 1); }

            if (za && !zb) return true;
            if (!za && zb) return false;

            bool answer = true;

            if (!za && !zb) answer = false;

            if (a.Length > b.Length) return answer;
            if (a.Length < b.Length) return !answer;

            int la = a.Length;
            for (int i = 0; i < la; ++i)
            {
                if (Convert.ToByte(a[i]) > Convert.ToByte(b[i])) return answer;
                if (Convert.ToByte(a[i]) < Convert.ToByte(b[i])) return !answer;
            }

            return false;
        }

        public bool Less(string a, string b)
        {
            if (Equal(a, b)) return false;

            bool za = true;
            bool zb = true;

            if (a[0] == '-') { za = false; a = a.Remove(0, 1); }
            if (b[0] == '-') { zb = false; b = b.Remove(0, 1); }

            if (za && !zb) return false;
            if (!za && zb) return true;

            bool answer = true;

            if (!za && !zb) answer = false;

            if (a.Length < b.Length) return answer;
            if (a.Length > b.Length) return !answer;

            int la = a.Length;
            for (int i = 0; i < la; ++i)
            {
                if (Convert.ToByte(a[i]) < Convert.ToByte(b[i])) return answer;
                if (Convert.ToByte(a[i]) > Convert.ToByte(b[i])) return !answer;
            }

            return false;
        }

        public bool Equal(string a, string b)
        {
            if (a.Equals(b)) return true;

            return false;
        }

        public string Add(string a, string b)
        {
            bool za = true;
            bool zb = true;

            if (a[0] == '-') { za = false; a = a.Remove(0, 1); }
            if (b[0] == '-') { zb = false; b = b.Remove(0, 1); }

            if ((za && zb) || (!za && !zb))
            {
                int la = a.Length;
                int lb = b.Length;

                if (la > lb)
                {
                    int dif = la - lb;
                    string buf = "";
                    for (int i = 0; i < dif; ++i)
                        buf += "0";
                    b = b.Insert(0, buf);
                }
                if (la < lb)
                {
                    int dif = lb - la;
                    string buf = "";
                    for (int i = 0; i < dif; ++i)
                        buf += "0";
                    a = a.Insert(0, buf);
                    la = lb;
                }

                int sum = 0;
                List<int> asb = new List<int>(getList(a));
                List<int> bsb = new List<int>(getList(b));
                List<int> r = new List<int>();
                for (int i = asb.Count - 1; i >= 0; --i)
                {
                    sum += asb[i] + bsb[i];
                    r.Insert(0, (sum % MAX));
                    sum /= MAX;
                }

                if (sum > 0) r.Insert(0, sum);

                if (!za) return "-" + outString(r);
                return outString(r);
            }

            if (za && !zb) return Sub(a, b);
            return Sub(b, a);
        }

        public string Sub(string a, string b)
        {
            if (Equal(a, b)) return "0";

            bool za = true;
            bool zb = true;

            if (a[0] == '-') { za = false; a = a.Remove(0, 1); }
            if (b[0] == '-') { zb = false; b = b.Remove(0, 1); }

            bool firstMore = true;
            if (Less(a, b)) firstMore = false;

            if (za && zb && firstMore)
            {
                List<int> asb = new List<int>(getList(a));
                List<int> bsb = new List<int>(getList(b));
                int la = asb.Count;
                int lb = bsb.Count;

                for (int i = 1; i <= lb; ++i)
                {
                    asb[la - i] -= bsb[lb - i];
                }
                for (int i = la - 1; i > 0; --i)
                {
                    if (asb[i] < 0)
                    {
                        asb[i] += MAX;
                        --asb[i - 1];
                    }
                }
                while (asb[0] == 0)
                    asb.RemoveAt(0);

                return outString(asb);
            }
            if (za && !zb) return Add(a, b);
            if (!za && zb) return "-" + Add(a, b);
            if (za && zb && !firstMore) return "-" + Sub(b, a);
            if (!firstMore) return Sub(b, a);
            return "-" + Sub(a, b);
        }

        public string Mult(string a, string b)
        {
            if (a == "0" || b == "0") return "0";
            if (More(b, a)) return Mult(b, a);

            bool za = true;
            bool zb = true;

            if (a[0] == '-') { za = false; a = a.Remove(0, 1); }
            if (b[0] == '-') { zb = false; b = b.Remove(0, 1); }

            List<int> asb = new List<int>(getList(a));
            List<int> bsb = new List<int>(getList(b));
            List<int> r = new List<int>();
            string bufForNull = "";
            string res = "0";
            int la = asb.Count;
            int lb = bsb.Count;
            long mul = 0;
            int buf = 0;
            for (int i = lb - 1; i >= 0; --i)
            {
                mul = 0;
                r.Clear();
                buf = bsb[i];
                for (int j = la - 1; j >= 0; --j)
                {
                    mul += Convert.ToInt64(asb[j]) * Convert.ToInt64(buf);
                    r.Insert(0, Convert.ToInt32(mul % MAX));
                    mul /= MAX;
                }
                if (mul > 0) r.Insert(0, Convert.ToInt32(mul));
                res = Add(res, outString(r) + bufForNull);
                bufForNull += "000000000";
            }

            if ((za && zb) || (!za && !zb)) return res;
            return "-" + res;
        }

        public string Div(string a, string b)
        {
            if (b == "0") return "0";
            if (Equal(a, b)) return "1";

            bool za = true;
            bool zb = true;

            if (a[0] == '-') { za = false; a = a.Remove(0, 1); }
            if (b[0] == '-') { zb = false; b = b.Remove(0, 1); }
            if (Equal(a, b)) return "-1";

            if (Less(a, b)) return "0";

            List<int> r = new List<int>();
            int la = a.Length;
            int lb = b.Length;
            int buf = 0;

            string sub = a.Substring(0, lb - 1);
            for (int i = lb-1; i < la; ++i)
            {
                buf = 0;
                sub += a[i];
                while (!Less(sub, b))
                {
                    ++buf;
                    sub = Sub(sub, b);
                }
                r.Add(buf);
                while (sub.Length > 0 && sub[0] == '0') sub = sub.Remove(0, 1);
            }

            while (r[0] == 0)
                r.RemoveAt(0);

            int k = 1;
            int m = 0;

            List<int> res = new List<int>();
            int count = r.Count - LENGTH * (r.Count / LENGTH);
            if (count != 0)
            {
                for (int i = count - 1; i >= 0; --i)
                {
                    m += r[i] * k;
                    k *= 10;
                }
                res.Add(m);
                r.RemoveRange(0, count);
            }
            k = MAX;
            m = 0;
            for (int i = 0; i < r.Count; ++i)
            {
                k /= 10;
                m += r[i] * k;
                if (k == 1)
                {
                    res.Add(m);
                    k = MAX;
                    m = 0;
                }
            }
            if ((za && zb) || (!za && !zb)) return outString(res);
            return "-" + outString(res);
        }

        public string Mod(string a, string b)
        {
            if (b == "0") return "0";

            return Sub(a, Mult(b, Div(a,b)));
        }

        public string Pow(string x, string n)
        {
            if (n == "0")
            {
                return "1";
            }

            if (Convert.ToInt32(n[n.Length - 1]) % 2 == 0)
            {
                string p = Pow(x, Div(n, "2"));
                return Mult(p, p);
            }
            else
            {
                return Mult(x, Pow(x, Sub(n, "1")));
            }
        }

        public string Add(string a, string b, string mod)
        {
            return Mod(Add(a, b), mod);
        }

        public string Sub(string a, string b, string mod)
        {
            return Mod(Sub(a, b), mod);
        }

        public string Mult(string a, string b, string mod)
        {
            return Mod(Mult(a, b), mod);
        }

        public string Div(string a, string b, string mod)
        {
            return Mod(Div(a, b), mod);
        }

        public string Pow(string x, string n, string mod)
        {
            if (n == "0")
            {
                return "1";
            }

            if (Convert.ToInt32(n[n.Length - 1]) % 2 == 0)
            {
                string p = Pow(x, Div(n, "2"), mod);
                return Mult(p, p, mod);
            }
            else
            {
                return Mult(x, Pow(x, Sub(n, "1"), mod), mod);
            }
        }

        public string Mod(string a, string b, string mod)
        {
            return Mod(Mod(a, b), mod);
        }

        public string Sqrt(string n)
        {
            string r = "1";
            string q = "";
            for (; ; )
            {
                q = Div(Add(r, Div(n, r)), "2");
                if (!Less(Pow(Add(q, "1"), "2"), n) && !More(Pow(q, "2"), n)) break;
                r = q;
            }
            return q;
        }

        public string Sqrt2(string n)
        {
            string sqrt = "0";
            string k = "1";
            while (!More(k, n))
            {
                n = Sub(n, k);
                k = Add(k, "2");
                sqrt = Add(sqrt, "1");
            }
            return sqrt;
        }

        public string China(List<string> b, List<string> a) // return X ::=  (X mod a[i] == b[i])
        {
            string M = "1";
            int l = b.Count;
            foreach (string ai in a) M = Mult(M, ai);
            List<string> m = new List<string>();
            List<string> m1 = new List<string>();
            for (int i = 0; i < l; ++i)
            {
                m.Add(Div(M, a[i]));
                m1.Add(Mod(m[i], a[i]));
            }
            List<string> y = new List<string>();
            for (int i = 0; i < l; ++i)
            {
                y.Add("1");
                while (Mod(Sub(Mult(y[i], m1[i]), b[i]), a[i]) != "0") y[i] = Add(y[i], "1");
            }
            string res = Mult(m[0], y[0], M);
            for (int i = 1; i < l; ++i) res = Add(res, Mult(m[i], y[i], M));
            return Mod(res, M);
        }

        public string China2(List<string> b, List<string> a) // return X ::=  (X mod a[i] == b[i])
        {
            List<List<string>> all = new List<List<string>>();
            foreach (string s in b)
            {
                List<string> buf = new List<string>();
                buf.Add(s);
                all.Add(buf);
            }

            int l = all.Count;
            List<string> res = new List<string>();
            while (true)
            {
                res.Clear();
                res.AddRange(all[0]);
                for (int i = 1; i < l; ++i)
                {
                    List<string> buf = new List<string>();
                    buf.AddRange(res.Intersect(all[i]));
                    res.Clear();
                    if (buf.Count == 0) break;
                    res.AddRange(buf);
                }
                if (res.Count != 0) return res[0];
                for (int i = 0; i < l; ++i)
                {
                    all[i].Add(Add(all[i].Last(), a[i]));
                }
            }
        }
    }
}
