namespace LINQassign.Tests;

public class UnitTest1
{
    [Fact]
    public void ReturnEvenNUmberstest()
    {
       ArrayFunctions arrayFunctions = new ArrayFunctions();

       int[] evens = arrayFunctions.returnEvenNumbers();

       Console.WriteLine(evens);
    }
}
