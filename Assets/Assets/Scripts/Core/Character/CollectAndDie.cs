using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CollectAndDie : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI levelScore;
    public int score = 1;
    public MoveAndDetect moveAndDetectRef;
    public MyGameManager gameManager;
    public int highscore;

    public int nextLevelReq = 2;
    public int nextLevelLoad;

    public string hearthTag = "hearth";
    public string obstacleTag = "obstacle";

     public Animator animator;

    void Start () {
        animator.SetBool("Dead", false);
        highscore = PlayerPrefs.GetInt("highscore"); 
        
    }

   

    // assign hearth and obstacle missions
    private void OnTriggerEnter2D(Collider2D other) {
        
        if (other.gameObject.tag == hearthTag)
        {
            Debug.Log(other.gameObject.tag);



            //score ingame changes
            scoreText.text = score.ToString();
            score++;

            

            if (score > highscore)
            {
                highscore = score;
            }
            else {
                highscore = 1;
            }

            PlayerPrefs.SetInt("highscore", highscore);
            
            moveAndDetectRef.moveSpeed = moveAndDetectRef.moveSpeed + 1.0f;

            

        }

        if (other.gameObject.tag == obstacleTag)
        {

            animator.SetBool("Dead", true);
            levelScore.text = (highscore-1).ToString();
            gameManager.DeathAnimAndStopCharacter();
            
            
        }

        
    }
    
    
}

