using UnityEngine;
using UnityEngine.Events; //https://docs.unity3d.com/ScriptReference/Events.UnityEvent.html

[System.Serializable]//https://docs.unity3d.com/ScriptReference/Serializable.html 
//https://docs.unity3d.com/Manual/script-Serialization.html#HowUnityUsesSerialization
public class UnityGameObjectEvent : UnityEvent<GameObject> { }
//https://docs.unity3d.com/ScriptReference/Events.UnityEvent_1.html
public class EventListener : MonoBehaviour
{
    public Event gEvent;
    public UnityGameObjectEvent response = new UnityGameObjectEvent();
    private void OnEnable()
    {
        gEvent.Register(this);
    }
    private void OnDisable()
    {
        gEvent.Unregister(this);
    }
    public void OnEventOccurs(GameObject go)
    {
        response.Invoke(go);
    }
}