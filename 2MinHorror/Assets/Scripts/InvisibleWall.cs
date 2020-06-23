using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleWall : MonoBehaviour
{
    private AudioSource[] allAudioSources;
    public GameObject GoatBodies, CreepySound;

    private void Start()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[]; 
        
    }

    public void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<BoxCollider>().isTrigger = false; 
        GoatBodies.SetActive(true);
        foreach (var audio in allAudioSources)
        {
            audio.Stop();
        }
        CreepySound.SetActive(true);
    }
}
