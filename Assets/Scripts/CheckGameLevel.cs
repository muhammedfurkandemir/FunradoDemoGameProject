using UnityEngine;

public class CheckGameLevel : MonoBehaviour
{
    public GameManager gameManager;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FriendlyCharacter"))
        {
            gameManager.LevelPass();
        }
    }
}
