using UnityEngine;


public class BoxingUnboxing : MonoBehaviour
{
    //part1
    int health = 100;
    void Start()
    {
        object health2 = health;
        int health3 = (int)health2;
        health3 = 4;
        Debug.Log(health);
        Debug.Log(health2);
        Debug.Log(health3);
    }


}
