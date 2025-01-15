using System;
using UnityEngine;
public class BuiltInDelegatesExample : MonoBehaviour
{
    //part3
    public delegate void Action();
    Func<int, int> square;
    Predicate<int> isEven;
    void Start()
    {
        Action logMessage;
        logMessage = () => Debug.Log("Hello from Action delegate!");
        logMessage();

        square = (int no) => (int)(Math.Pow(no, 2));
        Debug.Log($"Square: {square(5)}");

        isEven = (int no) => no % 2 == 0;
        Debug.Log($"Is 4 even? {isEven(4)}");
    }

}
