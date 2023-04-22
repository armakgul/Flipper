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
  

    public string hearthTag = "hearth";
    public string obstacleTag = "obstacle";

     public Animator animator;


    // LEVEL TOPSCORE VE HIGHCORELARI

    public int nextLevelReq1 = 7;
    public int nextLevelReq2 = 8;
    public int nextLevelReq3 = 9;
    public int nextLevelReq4 = 10;
    public int nextLevelReq5 = 3;
    
    //public int nextLevelReq6 = 3;

    public int nextLevelLoad;
    public int currentLevel;
    public int highscore1;
    public int highscore2;
    public int highscore3;
    public int highscore4;
    public int highscore5;
    public int highscore6;

    void Start () {
        animator.SetBool("Dead", false);
        
        currentLevel = SceneManager.GetActiveScene().buildIndex;
        

        if (currentLevel == 1)
        {
            highscore1 = PlayerPrefs.GetInt("highscore1");
        }
         if (currentLevel == 2)
        {
            highscore2 = PlayerPrefs.GetInt("highscore2");
        }
        if (currentLevel == 3)
        {
            highscore3 = PlayerPrefs.GetInt("highscore3");
        }
        if (currentLevel == 4)
        {
            highscore4 = PlayerPrefs.GetInt("highscore4");
        }
        if (currentLevel == 5)
        {
            highscore5 = PlayerPrefs.GetInt("highscore5");
        }
    
        /*
        highscore1 = 1;
        highscore2 = 1;
        highscore3 = 1;
        highscore4 = 1;    
        highscore5 = 1;
        highscore6 = 1;
        */
        Debug.Log("highscore1 is : " + highscore1);
        Debug.Log("highscore2 is : " + highscore2);
        Debug.Log("highscore3 is : " + highscore3);
        Debug.Log("highscore4 is : " + highscore4);
        Debug.Log("highscore5 is : " + highscore5);
        Debug.Log("highscore6 is : " + highscore6);


        // PLAY WALKING EFFECT
        FindObjectOfType<AudioManager>().Play("Walking");


    }

   

    // assign hearth and obstacle missions
    private void OnTriggerEnter2D(Collider2D other) {
        
        if (other.gameObject.tag == hearthTag)
        {

            FindObjectOfType<AudioManager>().PitchInc("Walking");

   
            //score ingame changes
            scoreText.text = score.ToString();
            score++;
            
            //LEVEL 1
            if (currentLevel == 1)
            {
                
                 if (score > highscore1)
                {
                    highscore1 = score;
                    PlayerPrefs.SetInt("highscore1", highscore1);
                }
                
                
                
                 if (highscore1 >= nextLevelReq1 && currentLevel >= PlayerPrefs.GetInt("levelAt"))
                {
                    
                        Debug.Log(highscore1);
                        nextLevelLoad = currentLevel + 1;
                        PlayerPrefs.SetInt("levelAt", nextLevelLoad);
                    
                }
                
                Debug.Log("nextLevelLoad is :" + nextLevelLoad);
                Debug.Log("levelAt is :" + PlayerPrefs.GetInt("levelAt"));

            }
            //LEVEL 2
            if (currentLevel == 2)
            {
                
                 if (score > highscore2)
                {
                    highscore2 = score;
                    PlayerPrefs.SetInt("highscore2", highscore2);
                }
                
                
                
                 if (highscore2 >= nextLevelReq2 && currentLevel >= PlayerPrefs.GetInt("levelAt"))
                {
                    
                    
                    
                        nextLevelLoad = currentLevel + 1;
                        PlayerPrefs.SetInt("levelAt", nextLevelLoad);
                        
                    
                }
            }
            //LEVEL 3
            if (currentLevel == 3)
            {
                
                 if (score > highscore3)
                {
                    highscore3 = score;
                    PlayerPrefs.SetInt("highscore3", highscore3);
                }
                
                
                
                 if (highscore3 >= nextLevelReq3 && currentLevel >= PlayerPrefs.GetInt("levelAt"))
                {
                    
                    
                        Debug.Log(highscore3);
                        nextLevelLoad = currentLevel + 1;
                        PlayerPrefs.SetInt("levelAt", nextLevelLoad);
                        
                    
                }
            }
            //LEVEL 4
            if (currentLevel == 4)
            {
                
                 if (score > highscore4)
                {
                    highscore4 = score;
                    PlayerPrefs.SetInt("highscore4", highscore4);
                }
                
                
                
                 if (highscore4 >= nextLevelReq4 && currentLevel >= PlayerPrefs.GetInt("levelAt"))
                {
                    
                    
                    
                        Debug.Log(highscore4);
                        nextLevelLoad = currentLevel + 1;
                        PlayerPrefs.SetInt("levelAt", nextLevelLoad);
                        
                    
                }
            } 
            //LEVEL 5   
            if (currentLevel == 5)
            {
                
                 if (score > highscore5)
                {
                    highscore5 = score;
                    PlayerPrefs.SetInt("highscore5", highscore5);
                }
                
                
                
                 if (highscore5 >= nextLevelReq5 && currentLevel >= PlayerPrefs.GetInt("levelAt"))
                {
                    
                    
                    
                        Debug.Log(highscore5);
                        nextLevelLoad = currentLevel + 1;
                        PlayerPrefs.SetInt("levelAt", nextLevelLoad);
                        
                    
                }
            }
            
            // VELO INC BY COLLECT
            moveAndDetectRef.moveSpeed = moveAndDetectRef.moveSpeed + 1.0f;

            

        }

        if (other.gameObject.tag == obstacleTag)
        {

            animator.SetBool("Dead", true);
            if (currentLevel == 1) {
                levelScore.text = (highscore1-1).ToString();
            }
            if (currentLevel == 2) {
                levelScore.text = (highscore2-1).ToString();
            }
            if (currentLevel == 3) {
                levelScore.text = (highscore3-1).ToString();
            }
            if (currentLevel == 4) {
                levelScore.text = (highscore4-1).ToString();
            }
            if (currentLevel == 5) {
                levelScore.text = (highscore5-1).ToString();
            }
            if (currentLevel == 6) {
                levelScore.text = (highscore6-1).ToString();
            }
            
            // SOUND STUFF
            FindObjectOfType<AudioManager>().Play("Player Death");
            FindObjectOfType<AudioManager>().Stop("Walking");
            
            gameManager.DeathAnimAndStopCharacter();
            
            
        }

        
    }
    
    
}

