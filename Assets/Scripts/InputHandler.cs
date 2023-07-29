using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameObject actor;
    Animator anim;
    Command runningMovement, atackMovement;
    public bool isAttack=false;
    public bool isMoveEnemy=false;
    void Start()
    {
        runningMovement = new Run();
        atackMovement= new Attack();
        anim = actor.GetComponent<Animator>();
        
    }

    
    void Update()
    {
        

        if (Input.GetMouseButtonDown(0) && this.gameObject.CompareTag("FriendlyCharacter")) 
        {
            runningMovement.Execute(anim,true);
        }
        if (this.gameObject.CompareTag("EnemyCharacter")&& isMoveEnemy)
        {
            runningMovement.Execute(anim, true);
        }
        if (this.gameObject.CompareTag("EnemyCharacter") && !isMoveEnemy)
        {
            runningMovement.Execute(anim, false);
        }
        if (Input.GetMouseButtonUp(0) && this.gameObject.CompareTag("FriendlyCharacter")) 
        { 
            runningMovement.Execute(anim,false);
        }
        if (isAttack)
        {
            atackMovement.Execute(anim,true);
            isAttack = !isAttack;
        }
    }

}
