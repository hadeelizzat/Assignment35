using System.Collections.Generic;
using UnityEngine;

public class ListMethodsExample : MonoBehaviour
{
    //part4,part5
    List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };
    List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
    List<int> filteredNumbers;
    void Start()
    {
        //1
        numbers.Sort((int x, int y) => y.CompareTo(x));
        print(string.Join(", ", numbers));
        //2
        filteredNumbers = numbers2.FindAll((int no) => no % 2 == 0);
        print(string.Join(", ", filteredNumbers));
    }
}
