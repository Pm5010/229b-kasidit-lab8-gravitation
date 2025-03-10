using System;
using UnityEngine;

public class Grvit : MonoBehaviour
{
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void attract(Grvit other)
    {
        Rigidbody ohterRb = other.rb;

        Vector3 direction = rb.position - ohterRb.position;
        float distance = direction.magnitude;
        
        float forceMagnitude = 
    }
}
