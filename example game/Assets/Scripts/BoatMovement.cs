﻿using System.Collections;
using UnityEngine;

public class BoatMovement : MonoBehaviour
{
    public float turnSpeed = 1000f;
    public float accellerateSpeed = 1000f;

    private Rigidbody rbody; 


    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rbody.AddTorque(0f, h * turnSpeed * Time.deltaTime, 0f);
        rbody.AddForce(transform.forward * v * accellerateSpeed * Time.deltaTime);
    }
}
