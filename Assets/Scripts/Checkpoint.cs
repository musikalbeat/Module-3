using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public bool StartingPoint = false;

    private Vector3 checkPosition;
    private Vector3 playerPosition;
    private GameObject player;
    
    void Start()
    {
        checkPosition = transform.position;
        player = GameObject.FindGameObjectWithTag("Player");

        if (StartingPoint)
        {
            player.transform.position = checkPosition;
            player.GetComponent<PlayerController>().Checkpoint = checkPosition;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        player.GetComponent<PlayerController>().Checkpoint = checkPosition;
    }
}
