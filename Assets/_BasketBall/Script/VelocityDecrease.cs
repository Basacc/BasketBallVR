using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityDecrease : MonoBehaviour {
        
    public float velocityMultiplicator;

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "ball")
        {
            Rigidbody rigidbody = other.gameObject.GetComponent<Rigidbody>();
            rigidbody.velocity *= velocityMultiplicator;
        }
        
    }
}
