using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seal : MonoBehaviour
{
    public GameObject Player;

    public float EnemyDistanceRun = 4.0f;

    private UnityEngine.AI.NavMeshAgent _agent;

    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    
    {   
        float distance = Vector3.Distance(transform.position, Player.transform.position);


         //run away from player
        if (distance < EnemyDistanceRun)
        {
            //vector player to me
            Vector3 dirToPlayer = transform.position - Player.transform.position;
            Vector3 newPos = transform.position + dirToPlayer;

            _agent.SetDestination(newPos);
        }
        



    }


}
