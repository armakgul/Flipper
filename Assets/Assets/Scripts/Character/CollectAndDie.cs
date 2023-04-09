using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CollectAndDie : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    float score = 1;
    public MoveAndDetect moveAndDetectRef;
    public MyGameManager gameManager;

    public string hearthTag = "hearth";
    public string obstacleTag = "obstacle";

     public Animator animator;

    void Start () {
        animator.SetBool("Dead", false);
    }


    // assign hearth and obstacle missions
    private void OnTriggerEnter2D(Collider2D other) {
        
        if (other.gameObject.tag == hearthTag)
        {
            Debug.Log(other.gameObject.tag);
            scoreText.text = score.ToString();
            score++;
            moveAndDetectRef.moveSpeed = moveAndDetectRef.moveSpeed + 1.0f;

        }

        if (other.gameObject.tag == obstacleTag)
        {

            animator.SetBool("Dead", true);
            gameManager.DeathAnimAndStopCharacter();
            Debug.Log("dead");

            
            
        }

        
    }
    
    
}

