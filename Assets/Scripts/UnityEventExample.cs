using UnityEngine;
using UnityEngine.Events;
public class UnityEventExample : MonoBehaviour
{
    //part6
    public UnityEvent onEventTriggered;
    void Start()
    {
        onEventTriggered = new UnityEvent();
        onEventTriggered.AddListener(OnEventResponse.EventListner);

    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            onEventTriggered?.Invoke();
        }
    }
}
