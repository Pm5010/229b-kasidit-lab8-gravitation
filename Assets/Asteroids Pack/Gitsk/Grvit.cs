using System;
using System.Collections.Generic;
using UnityEngine;

public class Grvit : MonoBehaviour
{
    Rigidbody rb;
    const float G = 0.006674f;
    public static List<Grvit> planetLists;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        if (planetLists == null)
        {
            planetLists = new List<Grvit>();
        }
        
        planetLists.Add(this);
    }

    private void FixedUpdate()
    {
        foreach (var planet in planetLists)
        {
            if(planet != this)
            attract(planet);
        }
    }

    void attract(Grvit other)
    {
        Rigidbody otherRb = other.rb;

        Vector3 direction = rb.position - otherRb.position;
        float distance = direction.magnitude;

        float forceMagnitude = G * ((rb.mass * otherRb.mass) / Mathf.Pow(distance, 2));
        Vector3 finalForce = forceMagnitude * direction.normalized;
        
        otherRb.AddForce(finalForce);
    }
}
