using UnityEngine;

public class Item : MonoBehaviour
{
    public Event PickUp;
    public int upgradeLevel;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("FriendlyCharacter"))
        {
            Debug.Log("Character upgrade");
            PickUp.Occured(this.gameObject);
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            this.gameObject.GetComponent<Collider>().enabled = false;
            this.gameObject.GetComponent<Light>().enabled = false;
            Destroy(this.gameObject, 5f);
            
        }
    }
    
}