using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMe : MonoBehaviour
{
    public GameObject Goat1, Goat2;
    public bool Goat1Selected, Goat2Selected; 
    
    // Start is called before the first frame update
    void Start()
    {
        Goat1Selected = false;
        Goat2Selected = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            
        }
    }
}
