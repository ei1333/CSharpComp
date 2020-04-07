class Printer
{
  public Printer()
  {
    var sw = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
    Console.SetOut(sw);
  }

  ~Printer() => flush();

  public void println(string a) => Console.WriteLine(a);
  public void println<T>(IEnumerable<T> a) => println(string.Join(" ", a));
  public void println(params object[] a) => println(string.Join(" ", a));

  public void print<T>(string a) => Console.Write(a);
  public void print<T>(IEnumerable<T> a) => print(string.Join(" ", a));
  public void print(params object[] a) => print(string.Join(" ", a));

  public void printArray<T>(params T[] a)
  {
    foreach (var x in a) Console.WriteLine(x);
  }
  public void flush() => Console.Out.Flush();
}
