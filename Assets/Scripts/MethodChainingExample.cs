
using UnityEngine;

public class MethodChainingExample : MonoBehaviour
{
    class Mathcube
    {
        public GameObject cube = GameObject.Find("Cube");

        public Mathcube SetPosition(Vector3 position)
        {
            cube.transform.position = position;
            return this;
        }
        public Mathcube SetRotation(Vector3 rotation)
        {
            cube.transform.rotation = Quaternion.Euler(rotation);
            return this;
        }
        public Mathcube SetScale(Vector3 scale)
        {
            cube.transform.localScale = scale;
            return this;
        }
    }
    void Start()
    {
        Mathcube mathcube = new Mathcube();
        mathcube.SetPosition(new Vector3(0, 1, 0)).SetRotation(new Vector3(45, 0, 0)).SetScale(new Vector3(2, 2, 2));
    }
}
