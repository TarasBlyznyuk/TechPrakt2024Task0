// See https://aka.ms/new-console-template for more information

namespace AdditionProj;

internal static class Program {
    public static void Main() {
        var sum = Enumerable.Range(0, 2).Sum(_ => GetNumFromInput());
        Console.WriteLine($"Final number: {sum}");
    }

    private static int GetNumFromInput() {
        Console.Write("Enter the number: ");
        return int.TryParse(Console.ReadLine(), out var num) ? num : 0;
    }
}