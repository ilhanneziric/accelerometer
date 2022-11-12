using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class kreten : MonoBehaviour
{
    private float speed = 2f;
    public randomkreiraj rankre;
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "sabala")
            Debug.Log("sabala");
    }
    // void OnCollisionEnter(Collision collision)
    // {
    //     if(collision.collider.name == "sabala")
    //         Debug.Log("sabala");
    // }
    void Start()
    {
        rankre = GameObject.FindObjectOfType(typeof(randomkreiraj)) as randomkreiraj;
    }

    void FixedUpdate()
    {
        
        if (this.transform.position.y >= 15)
        {
            Destroy(this.gameObject);
        }
        else
        {
            this.transform.position += new Vector3(0, 5, 0) * speed * Time.deltaTime;
        }
    }
}
