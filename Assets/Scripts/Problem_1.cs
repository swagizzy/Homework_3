using UnityEngine;
public class Problem_1 : MonoBehaviour
{
    /*
     *Using a loop go through all of the elements in the part array and add them up to a sum
     *Stored in the int sum variable, then print it out
     *Your result should be 325580886
    */
    void Start()
    {
        int[] parts = { 12, 3, 4234, 123, 325453141, 123, 123213, 1, 4, 32 };
        int sum = 0;
        for (int swag = 0; swag < parts.Length; swag++)
        {
            sum += parts[swag];
        }
        print(sum);
    }
}

