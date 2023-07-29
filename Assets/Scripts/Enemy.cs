using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public LevelController levelController;
    public int enemyLevel;
    public InputHandler inputHandlerFriendly;
    public InputHandler inputHandlerEnemy;
    public GameManager gameManager;
    private float _attackRange=10;
    private float attackRadius = 45;
    
   
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("FriendlyCharacter"))
        {
            inputHandlerEnemy.isMoveEnemy = false;
            if (levelController.Level >= enemyLevel)
            {
                inputHandlerFriendly.isAttack = true;
                Destroy(this.gameObject, 1f);
                Debug.Log("Enemy is dead.");
            }
            else
            {
                inputHandlerEnemy.isAttack = true;
                Destroy(other.gameObject, 1f);
                Debug.Log("Friendly character is dead.");
                gameManager.GameOver();
            }

        }
    }
    private void EnemyAttackingRange()
    {
        //Collider[] hitColliders = Physics.
    }

    public float algilamaMesafesi = 10f;
    public float algilamaAci = 70f;

    void Update()
    {
        // Düşmanları tespit etmek için bir dizi oluşturuyoruz
        Collider[] tespitEdilenler = Physics.OverlapSphere(transform.position, algilamaMesafesi);

        foreach (Collider tespitEdilen in tespitEdilenler)
        {
            // Karakterin önünde mi kontrol ediyoruz
            Vector3 yon = (tespitEdilen.transform.position - transform.position).normalized;
            float aci = Vector3.Angle(transform.forward, yon);

            // Eğer düşmanın açısı algilamaAci değişkeni ile belirtilen açı aralığı içindeyse, düşmanı algıladık diyebiliriz
            if (aci <= algilamaAci / 2f)
            {
                if (tespitEdilen.gameObject.CompareTag("FriendlyCharacter"))
                {
                    Debug.Log("karakter tespit edildi");
                }
                //Debug.Log("Düşman algılandı: " + tespitEdilen.name);
            }
        }
    }
   
    
}







    

