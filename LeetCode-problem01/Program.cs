namespace LeetCode_problem01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the two sum leet code challenge");

            int[] nums = { 2, 7, 11, 15 };
            // test case 1
            int[] indices = TwoSum(nums, 9);
            DisplayResults(indices, "Test Case 1");

            nums = [3, 2, 4];
            // test case 1
            indices = TwoSum(nums, 6);
            DisplayResults(indices, "Test Case 2");

            nums = [1, 3, 7, 12, 15];
            // test case 1
            indices = TwoSum(nums, 19);
            DisplayResults(indices, "Test Case 3");

            Console.WriteLine("Bye");
        }

        static void DisplayResults(int[] indices, string msg)
        {
            Console.WriteLine(msg);
            foreach (int i in indices) {
                Console.Write($"index: {i}, ");
            }
                Console.WriteLine(" ");

        }

        static int[] TwoSum(int[] nums, int target){
            int[] indices = new int[2];
            bool found = false;
            for (int i = 0; i < nums.Length; i++) {
                if (found) {
                    break;
                }
                for ( int j = 0; j < nums.Length; j++) {
                    if (i != j) {
                     //   Console.Write($"{nums[i]} + {nums[j]}, ");
                        int sum = nums[i] + nums[j];
                        if (sum == target) {
                          //  Console.Write("Target!!!");
                            indices = [i, j];
                            found = true;
                            break;
                        }
                        
                    }
                }
               // Console.WriteLine("");
            }
            return indices;
        }
    }
}
