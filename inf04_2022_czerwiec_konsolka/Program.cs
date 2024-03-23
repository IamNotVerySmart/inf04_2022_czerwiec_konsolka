int[] tablica = new int[10];
WczytajTablice();
for (int i = 0; i < tablica.Length; i++)
{
    int maxIndex = Array.IndexOf(tablica, ZnajdzMax(i));
    tablica[i] = tablica[maxIndex] > tablica[i] ? tablica[maxIndex] : tablica[i];
}
Console.WriteLine("Posortowane"); foreach (int liczba in tablica) Console.Write(liczba + " ");
void WczytajTablice()
{
    Console.WriteLine("10 liczb:");
    for (int i = 0; i < 10; i++) tablica[i] = int.Parse(Console.ReadLine());
}
int ZnajdzMax(int start) { return tablica.ToList().GetRange(start, tablica.Length - start).Max(); }
/********************************************************
* nazwa funkcji: WcztajTablice, ZnajdzMax
* parametry wejściowe: start - int
* wartość zwracana: wartosc maksymalna w tablicy
* autor: 69420213769
* ****************************************************/
