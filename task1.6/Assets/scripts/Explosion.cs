using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public Rigidbody[] AffectedRigidbodies;
    public float Impulse;


    private void Start()
    {
        Explode();
    }

    private void Explode()
    {
        var center = transform.position;

        foreach (var affectedRigidbody in AffectedRigidbodies)
        {
            var offset = affectedRigidbody.position - center;
            var direction = offset.normalized;
            affectedRigidbody.AddForce(direction * Impulse, ForceMode.Impulse);
        }
    }
}
