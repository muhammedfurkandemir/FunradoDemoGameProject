using UnityEngine;

[CreateAssetMenu(fileName = "keydata", menuName = "Key Data", order = 51)]
public class KeyData : ScriptableObject
{
    public enum Key { none, red, blue,yellow }

    [SerializeField]
    private Key keyColor;
    [SerializeField]
    private bool pickUp;

    public Key KeyColor { get { return keyColor; } }
    public bool PickUp { 
        get { return pickUp; }
        set { pickUp = value; }
    }
}
