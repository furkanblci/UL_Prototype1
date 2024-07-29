using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerX : MonoBehaviour
{
    public float speed = 40;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(Vector3.forward*Time.deltaTime*speed);
    }
}
