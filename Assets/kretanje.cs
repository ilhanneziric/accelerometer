using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kretanje : MonoBehaviour
{
    public float speed = 0.5f;
    public Joystick joystick;
    private void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }
    private void Update()
    {
        transform.Translate(Input.acceleration.x * speed, 0, Input.acceleration.y * speed);
        var rigid = GetComponent<Rigidbody>();
        //rigid.velocity = new Vector3(joystick.Horizontal * 20f,
        //                                rigid.velocity.y,
         //                               joystick.Vertical * 20f);
    }
}
