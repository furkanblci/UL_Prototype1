using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;

 
    void Start()
    {

    }

  
    void FixedUpdate()
    {
      
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward *Time.deltaTime* speed);
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime*verticalInput);
        transform.Rotate(Vector3.up*Time.deltaTime*rotationSpeed*horizontalInput);
    }
}
