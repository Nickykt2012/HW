int Sum(int a, int b) 
{
  return a == b? b : a + Sum(a + 1, b);
}
Console.WriteLine(Sum (4, 8));
