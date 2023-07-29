using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public Event PickUp;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("FriendlyCharacter"))
        {
            Debug.Log("karakter geldi");
            PickUp.Occured(this.gameObject);
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            this.gameObject.GetComponent<Collider>().enabled = false;
            this.gameObject.GetComponent<Light>().enabled = false;
            Destroy(this.gameObject, 5f);
            
        }
    }
    
}