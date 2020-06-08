using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class SubtitleTiming : MonoBehaviour
{
    public TMP_Text subtitle; 
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeTextTime()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ChangeTextTime()
    {
        yield return new WaitForSeconds(4f);
        subtitle.text = ""; 
        //trigger goat sound
        Debug.Log("goat sound play");
        yield return new WaitForSeconds(3f);
        Debug.Log("subtitle changes");
        subtitle.text = "damn goats got out again"; 
        yield return new WaitForSeconds(2.5f);
        subtitle.text = "";
        yield return new WaitForSeconds(1.5f);
        subtitle.text = "best get them back into the barn before the coyotes get 'em'";
        yield return new WaitForSeconds(2.5f);
        subtitle.text = ""; 
    }
    
    
}
