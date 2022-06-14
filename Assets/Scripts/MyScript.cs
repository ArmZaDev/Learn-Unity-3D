using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public float RunSpeed = 10.0f;
    private Rigidbody myRigidBody;
    public Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        
    }
  
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Jump");
        float z = Input.GetAxisRaw("Vertical");
        
        movement = new Vector3(x, y, z);
    }

    private void FixedUpdate()
    {
        movePlayer(movement);
           
    }

    void movePlayer(Vector3 direction)
    {
        //myRigidBody.velocity = direction * RunSpeed;
        //myRigidBody.MovePosition(transform.position + (direction * RunSpeed * Time.deltaTime));
        myRigidBody.AddForce(direction * RunSpeed);
    }
}
