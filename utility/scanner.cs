class Scanner
{
  readonly CultureInfo ci = CultureInfo.InvariantCulture;
  string[] s;
  int i;
  readonly char[] cs = new char[] { ' ' };

  public Scanner()
  {
    s = new string[0];
    i = 0;
  }

  public string next()
  {
    if (i < s.Length) return s[i++];
    string st = Console.ReadLine();
    while (st == "") st = Console.ReadLine();
    s = st.Split(cs, StringSplitOptions.RemoveEmptyEntries);
    if (s.Length == 0) return next();
    i = 0;
    return s[i++];
  }

  public string nextLine() => Console.ReadLine();
  public int nextInt() => int.Parse(next());
  public long nextLong() => long.Parse(next());
  public double nextDouble() => double.Parse(next(), ci);

  public int[] nextArrayInt(int N, int add = 0)
  {
    int[] ret = new int[N];
    for (int i = 0; i < N; i++)
    {
      ret[i] = nextInt() + add;
    }
    return ret;
  }

  public long[] nextArrayLong(int N, long add = 0)
  {
    long[] ret = new long[N];
    for (int i = 0; i < N; i++)
    {
      ret[i] = nextLong() + add;
    }
    return ret;
  }

  public double[] nextArrayDouble(int N, double add = 0)
  {
    double[] ret = new double[N];
    for (int i = 0; i < N; i++)
    {
      ret[i] = nextDouble() + add;
    }
    return ret;
  }
}
