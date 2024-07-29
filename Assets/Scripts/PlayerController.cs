using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    private float horizontalInput;
    private float forwardInput;
    
    public Camera cam1,cam2;
    private bool isActiveCam;
    public KeyCode switcKey;

    void Start()
    {
        
    }

   
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        transform.Rotate(Vector3.up*Time.deltaTime*turnSpeed*horizontalInput);
        
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed*horizontalInput);
        
        if (Input.GetKeyDown(switcKey))
        {
            cam1.enabled = !cam1.enabled;
            cam2.enabled = !cam2.enabled;
        }

        if (gameObject.transform.position.y<-8)
        {
            SceneManager.LoadScene(0);
        }

    }
    
    
}
