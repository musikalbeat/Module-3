using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCamera : MonoBehaviour
{
    public GameObject CamRig;

    private GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void OnCollisionEnter(Collision other)
    {
        cam.transform.position  = CamRig.transform.position;
        cam.transform.rotation = CamRig.transform.rotation;
    }
}
