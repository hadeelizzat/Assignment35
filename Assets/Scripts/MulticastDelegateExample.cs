using System;
using UnityEngine;

public class MulticastDelegateExample : MonoBehaviour
{
    //part2
    public delegate void MathOperation(int number);
    MathOperation operation;
    void DoubleNumber(int number) => Debug.Log(number * 2);
    void SquareNumber(int number) => Debug.Log(Math.Pow(number, 2));
    void CubeNumber(int number) => Debug.Log(Math.Pow(number, 3));
    void Start()
    {
        operation += DoubleNumber;
        operation += SquareNumber;
        operation += CubeNumber;
        operation(5);
    }
    void OnDisable()
    {
        operation -= DoubleNumber;
        operation -= SquareNumber;
        operation -= CubeNumber;

    }


}
