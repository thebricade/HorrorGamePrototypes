using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMe : MonoBehaviour
{
    public Transform mTarget;
    private float mSpeed;
    private const float EPSILON = 0.1f;
    private bool hasTutorial;
    private bool recentWhistle; 
    
    //private int Speed;
    public bool followingPlayer; 
    
    // Start is called before the first frame update
    void Start()
    {
        followingPlayer = false;
        mSpeed = 1.4f;
        hasTutorial = false;
        recentWhistle = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (!followingPlayer)
        {
            
        }
        else
        {
            
            //FUCKING GOATS DON'T FLY
            var lookPos = mTarget.position - transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * mSpeed);
            if ((transform.position - mTarget.position).magnitude > EPSILON)
            {
                transform.Translate(0f,0f,mSpeed*Time.deltaTime);
            }
            
            
            
            /*transform.LookAt(mTarget.position);
            if ((transform.position - mTarget.position).magnitude > EPSILON)
            {
                //transform.position = Vector3.MoveTowards(transform.position, mTarget.position, mSpeed * Time.deltaTime);
                transform.Translate(0f,0f,mSpeed*Time.deltaTime);
               // transform.Translate(transform.forward * mSpeed * Time.deltaTime);
                
            }*/
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (!hasTutorial)
        {
            StartCoroutine(TutorialText());
        }
    }

    IEnumerator TutorialText()
    {
        hasTutorial = true;
        yield return new WaitForSeconds(1f);
        ServiceLocator._subtitleTiming.subtitle.text = "goats will follow you when you whistle. press 'e' to whistle''";
        //try to get the press 'e' to be on a new line 
        yield return new WaitForSeconds(2.5f);
        ServiceLocator._subtitleTiming.subtitle.text = ""; 

    }
    
    
    public void CheckWhistleRange()
    {
        
    } 

   public void OnTriggerStay(Collider other)
   {
       if (other.tag == "Player")
       {
           if (Input.GetKeyDown(KeyCode.E))
           {
               //add sound
               Debug.Log("whistle sound");
               followingPlayer = true;
           }
       }
   }
}
