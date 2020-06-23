using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleWall : MonoBehaviour
{
    public GameObject GoatBodies, CreepySound, BackgroundNoise; 

    public void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<BoxCollider>().isTrigger = false; 
        GoatBodies.SetActive(true);
        BackgroundNoise.SetActive(false);
        CreepySound.SetActive(true);
    }
}
