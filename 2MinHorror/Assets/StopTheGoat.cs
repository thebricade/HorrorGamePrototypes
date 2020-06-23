using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTheGoat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("I hit something");
        Debug.Log(other.name.ToString());
        if (other.name == "Goat1_Body")
        {
            ServiceLocator._Goat1.GetComponent<FollowMe>().followingPlayer = false; 
            Debug.Log("goat 1 stop");
        } 
        if (other.name == "Goat2_Body")
        {
            ServiceLocator._Goat2.GetComponent<FollowMe>().followingPlayer = false; 
            Debug.Log("goat 2 stop");
        } 
    }


    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("There was a collision");
    }
}
