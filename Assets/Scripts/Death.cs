using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    private GameObject player;
    private Vector3 checkPosition;

    void OnCollisionEnter(Collision other)
    {
        player = other.gameObject;
        checkPosition = player.GetComponent<PlayerController>().Checkpoint;
        
        player.transform.position = checkPosition;
    }
}
