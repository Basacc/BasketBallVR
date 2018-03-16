using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {
    public Transform objectToSpawn;
    public KeyCode touchToSpawn = KeyCode.Space;
    public Transform spawnPoint;
    public GameObject lastCreatedObject;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(touchToSpawn))
        {
            SpawnObject();
        }

	}

    protected virtual void SpawnObject()
    {
        lastCreatedObject = GameObject.Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation).gameObject;
    }
}
