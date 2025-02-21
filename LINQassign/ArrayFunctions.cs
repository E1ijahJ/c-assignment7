namespace LINQassign;

public class ArrayFunctions
{
  private int[] numbers;
  /// <summary>
  /// This is the initializer so whenver we initalize the function the array is also initialized that all the functions have accces
  /// </summary>
 public ArrayFunctions(){
  numbers = Enumerable.Range(0,1000000).ToArray();
 }

/// <summary>
/// this right here gets thee even numbers only by using modular division
/// </summary>
/// <param name="skip"></param>
/// <returns></returns>
public int[] returnEvenNumbers(int skip = 0){
  return numbers.Where(n => n%2 ==0).Skip(skip).ToArray();
  }
/// <summary>
/// This right here uses the same concept but this time uses gets the odd numbers while shuffling
/// </summary>
/// <param name="skip"></param>
/// <returns></returns>
public int[] returnOddShuffled(int skip = 0){
  Random random = new Random();
  return numbers.OrderBy(n=> random.Next()).Where(n=> n%2 !=0).Skip(skip).ToArray();
}
/// <summary>
/// This right here gets the overally stats for the array getting the average, minmum and maximum
/// </summary>
/// <returns></returns>
public double[] getStats(){
  return new double[] {numbers.Average(),numbers.Min(),numbers.Max()};
}
}
