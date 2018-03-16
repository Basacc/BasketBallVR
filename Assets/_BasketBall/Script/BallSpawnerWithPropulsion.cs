using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerWithPropulsion : BallSpawner {


    public Transform forceDirection;
    public float forceIntensity = 1;

    protected override void SpawnObject()
    {
        base.SpawnObject();
        Rigidbody rigidBodyOfBall = lastCreatedObject.GetComponent<Rigidbody>();

        if (rigidBodyOfBall != null)
        {
            rigidBodyOfBall.AddForce(CalcVelocity(), ForceMode.Impulse);
        }
    }

    public Vector3 CalcVelocity()
    {
        Vector3 velocity = forceDirection.forward * forceIntensity;
        return velocity;
    }

    public Vector3 DecreaseVelocity(Vector3 v)
    {
        v = v * 0.5f;
        return v;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rigidBodyOfBall = lastCreatedObject.GetComponent<Rigidbody>();
        rigidBodyOfBall.AddForce(DecreaseVelocity(CalcVelocity()), ForceMode.VelocityChange);
    }
}
