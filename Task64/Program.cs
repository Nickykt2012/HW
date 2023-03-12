string Nubmers(int a)
{
    if (a >= 1) return $"{a}{" "}" + Nubmers(a - 1);
    else return String.Empty;
}
Console.WriteLine(Nubmers(8));
