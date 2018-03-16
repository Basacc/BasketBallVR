using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBall : MonoBehaviour {

    public GameObject player;
    public Transform[] playerPositions;
    public int cptPosition;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        bool check = other.GetComponent<Scored>().scored;

        if (other.tag == "ball" && !check )
        {
            cptPosition++;
            DisplayScore.scoreValue++;
            SetPlayerPosition(cptPosition);
            check = true;
        }

    }

    void SetPlayerPosition(int pos)
    {
        if (pos<playerPositions.Length)
        {
        player.transform.position = playerPositions[pos].position;
        }
        else
        {
            player.transform.position = playerPositions[0].position;
            cptPosition = 0;
        }
    }
}
