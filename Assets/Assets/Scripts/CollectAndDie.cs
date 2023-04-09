using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectAndDie : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    float score = 1;

    private void OnTriggerEnter2D(Collider2D other) {
        

        if (other.gameObject.tag == "hearth")
        {
            Debug.Log(other.gameObject.tag);
            scoreText.text = score.ToString();
            score++;
        }

        if (other.gameObject.tag == "obstacle")
        {
            Debug.Log("dead");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
