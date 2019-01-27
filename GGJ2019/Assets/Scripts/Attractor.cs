using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    public Rigidbody rb;
    public float G;


    private void FixedUpdate()
    {
        Attractor[] attractors = FindObjectsOfType<Attractor>();
        foreach (Attractor attractor in attractors)
        {
            if (attractor != this)
                Attract(attractor);
        }
    }

    void Attract(Attractor objToAttract)
    {
        Rigidbody rbToAttract = objToAttract.rb;

        Vector3 direction = rb.position - rbToAttract.position;
        float distance = direction.magnitude;

        float forceMagnitute = G * (rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);
        Vector3 force = direction.normalized * forceMagnitute;

        rbToAttract.AddForce(force);
    }
}
