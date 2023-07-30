using UnityEngine;

public class KeyController : MonoBehaviour
{
    public KeyData keyData;
    void Start()
    {
        keyData.PickUp = false;
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FriendlyCharacter"))
        {
            keyData.PickUp=true;
            gameObject.SetActive(false);
        }
    }
}
