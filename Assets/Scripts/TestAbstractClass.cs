using UnityEngine;
public class TestAbstractClass : MonoBehaviour
{
    //part8
    DerivedClassExample derivedClassExample;
    void Start()
    {
        derivedClassExample = new DerivedClassExample();
        derivedClassExample.PerformAction();
        derivedClassExample.PrintInfo();
    }
}
