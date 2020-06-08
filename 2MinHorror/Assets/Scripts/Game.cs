using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        InitializeServices();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitializeServices()
    {
        ServiceLocator._game = this;
        ServiceLocator._subtitleTiming = gameObject.GetComponent<SubtitleTiming>(); 
        ServiceLocator._Goat1 = GameObject.Find("Goat"); 
        ServiceLocator._Goat2 = GameObject.Find("Goat2");
    }
}
