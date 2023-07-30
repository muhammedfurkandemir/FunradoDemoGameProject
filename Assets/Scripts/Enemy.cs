using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameManager gameManager;
    public int enemyLevel;
    public TextMeshProUGUI textMeshPro;

    private float _attackRange=3.7f;
    private float attackRadius = 80f;

    public InputHandler inputHandlerFriendly;
    public InputHandler inputHandlerEnemy;
    public LevelController levelController;
    private void Start()
    {
        textMeshPro.text="Lv."+enemyLevel.ToString();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("FriendlyCharacter"))
        {
            AttackControl();
        }
    }
    

    private void FixedUpdate()
    {
        EnemyDetectionRange();
    }
    private void EnemyDetectionRange()
    {
        
        Collider[] hits = Physics.OverlapSphere(transform.position, _attackRange);

        foreach (Collider hit in hits)
        {
            
            Vector3 direction = (hit.transform.position - transform.position).normalized;
            float radius = Vector3.Angle(transform.forward, direction);

           
            if (radius <= attackRadius / 2f)
            {
                if (hit.gameObject.CompareTag("FriendlyCharacter"))
                {
                    Debug.Log("Character is detected.");
                    AttackControl();
                }
                
            }
        }
    }
    private void AttackControl()
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
            Destroy(inputHandlerFriendly.gameObject, 1f);
            Debug.Log("Friendly character is dead.");
            gameManager.GameOver();
        }
    }




}







    

