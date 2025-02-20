namespace LINQassign;

public class ArrayFunctions
{
  private int[] numbers;
 public ArrayFunctions(){
  numbers = Enumerable.Range(0,1000000).ToArray();
 }

public int[] returnEvenNumbers(int skip = 0){
  return numbers.Where(n => n%2 ==0).Skip(skip).ToArray();
  }

public int[] returnOddShuffled(int skip = 0){
  Random random = new Random();
  return numbers.OrderBy(n=> random.Next()).Where(n=> n%2 !=0).Skip(skip).ToArray();
}
}
