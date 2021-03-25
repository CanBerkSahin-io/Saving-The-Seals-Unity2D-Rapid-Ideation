using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flee : MonoBehaviour
{
    public Transform target;

    public float speed = 3f;

    public float rotateSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
        transform.Rotate(1, 90, 1);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 direction = transform.position - target.position;

        if (direction.sqrMagnitude < 115f)
        {
            transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
            transform.forward = direction.normalized;
    
        }
        
    }
}
