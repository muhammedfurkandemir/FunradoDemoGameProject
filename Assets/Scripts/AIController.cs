using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    NavMeshAgent _navMeshAgent;
    [SerializeField] GameObject[] destinationPoints;
    public InputHandler inputHandler;
    int currentDestination;
    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        currentDestination = 0;
        _navMeshAgent.SetDestination(destinationPoints[currentDestination].transform.position);
        inputHandler.isMoveEnemy = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DestinationPoint"))
        {
            if (currentDestination == 0)
                currentDestination = 1;
            else
                currentDestination = 0;

            _navMeshAgent.SetDestination(destinationPoints[currentDestination].transform.position);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("FriendlyCharacter"))
        {
            Debug.Log("çarpışma oldu");
            _navMeshAgent.SetDestination(this.transform.position);
        }
    }
}
