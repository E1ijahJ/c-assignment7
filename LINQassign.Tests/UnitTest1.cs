namespace LINQassign.Tests;

public class UnitTest1
{
    [Fact]
    public void ReturnEvenNUmberstest()
    {
       ArrayFunctions arrayFunctions = new ArrayFunctions();

       int[] evens = arrayFunctions.returnEvenNumbers(9);

       Console.WriteLine(string.Join(",",evens));
    }

    [Fact]
    public void ReturnOddShufledNumberstest()
    {
       ArrayFunctions arrayFunctions = new ArrayFunctions();

       int[] odd = arrayFunctions.returnOddShuffled();

       ///Console.WriteLine(string.Join(",",odd));
    }


    [Fact]
    public void ReturnStatstest()
    {
       ArrayFunctions arrayFunctions = new ArrayFunctions();

       double[] stats = arrayFunctions.getStats();

       Console.WriteLine("Average 1. , Minimum 2. , MAximum 3.  "+ string.Join(" , ",stats));
    }
}
