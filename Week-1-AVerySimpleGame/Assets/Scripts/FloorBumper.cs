using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorBumper : MonoBehaviour
{
    public float bumpForce = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // Once hit the player, let the player bounced
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(bumpForce * Vector3.up);            
        }
    }
}
