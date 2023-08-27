Random rnd = new Random();
//Setting the size of the array

int array_size = 50;
//Instatiating an array of integers
int[] nums = new int[array_size];
//Setting target value
int target = rnd.Next(1, 50);
int counter = 0;

//Setting the values of the array
for(int i = 0; i < nums.Length; i++)
{
    nums[i] = rnd.Next(1, 50);
}

//Two Sum Algorithm O(n^2)
for(int i = 0; i < nums.Length; i++)
{
    for(int j = 0; j < nums.Length; j++)
    {

        if(nums[i] + nums[j] == target && i != j)
        {
            Console.WriteLine(String.Join(",", nums));
            Console.WriteLine("The sum of Index: [{0}] and Index: [{1}] is {2}", i, j, target);
            return;
        }
        else
        {
            counter++;
            if (counter == nums.Length * nums.Length)
            {
                Console.WriteLine(String.Join(",", nums));
                Console.WriteLine("No match found");
                return;
            }
        }
    }
}
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    int[] answer = new int[2];
    for(int i = 0; i < nums.Length; i++)
{
    for(int j = 0; j < nums.Length; j++)
    {
        if(nums[i] + nums[j] == target && i != j)
        {
            answer[0] = nums[i];
            answer[1] = nums[j];
            return answer;
        }
}
    }
    return answer;
    }
}