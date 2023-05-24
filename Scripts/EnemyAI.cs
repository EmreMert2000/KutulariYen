using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private Transform hedef;
    
    // Start is called before the first frame update
    void Start()
    {

        navMeshAgent = GetComponent<NavMeshAgent>();
        hedef = GameObject.FindGameObjectWithTag("Player").transform;
        InvokeRepeating("Speed", 0.3f,0.3f);
    }

   
    void Update()
    {

        transform.LookAt(hedef);
        navMeshAgent.SetDestination(hedef.position);
    }
    public void Speed()
    {
        navMeshAgent.speed += 1f;
       navMeshAgent.acceleration +=0.5f;
       
        
    }
}
