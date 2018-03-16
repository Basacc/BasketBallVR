using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OutLimitTeleport : MonoBehaviour {

    public int depth;
    public Transform respawn;
    public Transform objectToMove;
    public Rigidbody rigidbobyOfCharacter;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (objectToMove.position.y < depth)
        {
            objectToMove.position = respawn.position;
            rigidbobyOfCharacter.velocity = Vector3.zero;
        }
	}
}
