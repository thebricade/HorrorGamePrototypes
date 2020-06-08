using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMe : MonoBehaviour
{
    public Transform mTarget;
    private float mSpeed;
    private const float EPSILON = 0.1f;
    
    private int Speed;
    public bool followingPlayer; 
    
    // Start is called before the first frame update
    void Start()
    {
        followingPlayer = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (!followingPlayer)
        {
            
        }
        else
        {
            transform.LookAt(mTarget.position);
            if ((transform.position - mTarget.position).magnitude > EPSILON)
            {
                transform.Translate(0f,0f,mSpeed*Time.deltaTime);
            }
        }
    }
}
