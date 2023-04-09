using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectAndDie : MonoBehaviour
{
    public Text scoreText;

    private void OnCollisionEnter2D(Collision2D other) 
    {
        
        if(other.gameObject.tag == "hearth")
        {
            Debug.Log("hearth");
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
