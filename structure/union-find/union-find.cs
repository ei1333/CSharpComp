class UnionFind
{
  private int[] data;

  public UnionFind(int size)
  {
    data = Enumerable.Repeat(-1, size).ToArray();
  }

  public int find(int k)
  {
    if (data[k] < 0) return k;
    return data[k] = find(data[k]);
  }

  public bool unite(int x, int y)
  {
    x = find(x);
    y = find(y);
    if (x == y) return false;
    if (data[x] > data[y])
    {
      int z = x;
      x = y;
      y = z;
    }
    data[x] += data[y];
    data[y] = x;
    return true;
  }

  public int size(int k) => -data[find(k)];
}
