using UnityEngine;

public class LockController : MonoBehaviour
{
    public KeyData keyData;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("FriendlyCharacter"))
        {
            if (keyData.PickUp)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
