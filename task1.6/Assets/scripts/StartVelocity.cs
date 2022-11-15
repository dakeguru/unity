using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StartVelocity : MonoBehaviour
{
    public Vector3 Velocity;
    public Rigidbody Rigidbody;


    private void Start()
    {
        Rigidbody.velocity = Velocity;
    }

}
