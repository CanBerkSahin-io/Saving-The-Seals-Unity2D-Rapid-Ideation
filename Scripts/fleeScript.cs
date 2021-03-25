using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fleeScript : MonoBehaviour
{

    public float speed;

    public float stoppingDistance;
    
    public float retreatDistance;

    public Transform moveSpot;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public float faceRight;
    


    public Transform player;
    public Transform seal;
    // Start is called before the first frame update
    void Start()

    {
        seal = GameObject.FindGameObjectWithTag("seal").transform;
        player= GameObject.FindGameObjectWithTag("Player").transform;

        moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));

        faceRight = seal.transform.localScale.x;

        
    }

    // Update is called once per frame
  void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpot.position, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, player.position) > stoppingDistance) 
        {
            //transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));  // roam
        }
        else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = this.transform.position;  // stop
        }
        else if (Vector2.Distance(transform.position, player.position) <= retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);  // retreat
        }

        if(seal.transform.position.x >= player.transform.position.x)
        {
            //face right
            transform.eulerAngles = new Vector3(0,-180,0);
        }else
        {
            //face left
           transform.eulerAngles = new Vector3(0,0,0);
        }
        
    }

}

