namespace LINQassign;

public class ArrayFunctions
{
  private int[] numbers;
 public ArrayFunctions(){
  numbers = Enumerable.Range(0,10000000).ToArray();
 }

public int[] returnEvenNumbers(int skip = 0){
  return numbers.Where(n => n%2 ==0).Skip(skip).ToArray();
  }
}
