using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_control : MonoBehaviour
{
    public Vector3 sphereInitialVelocity;
    public Rigidbody rb;
    // Start is called before the first frame update
    private void Awake()
    {
        //sphereInitialVelocity = Vector3.down;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = sphereInitialVelocity;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb == null || rb.isKinematic)
        {
            //translate or update the transform position 
            //either rb.translate.position or translate.position
            transform.Translate(sphereInitialVelocity * Time.deltaTime);
        }
        else
        {
            //move with forces 
            //rb.AddForce(vector3.down);
        }
    }

    //notice that the collider data structure is passed here
    //to detection intersections with no physics     
    //check: static collider, IsTrigger, etc. in Inspector
    void OnTriggerEnter(Collider other) 
    {
        Debug.Log(gameObject.name + " is overlapped by " + other.gameObject.name);
    }

    //notice that the collision data structure is passed here
    //to detect collisions with physics etc.
    void OnCollisionEnter(Collision collision)
    {
        //notice that collision contains methods and data about the collsion
        Debug.Log(gameObject.name + " is hit by " + collision.gameObject.name);
    }
}
