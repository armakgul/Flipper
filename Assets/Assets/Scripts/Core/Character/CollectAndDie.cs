using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CollectAndDie : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI EndScoreText;
    public TextMeshProUGUI levelScore;

    public TextMeshProUGUI NextLevelHighScore;
    public TextMeshProUGUI NextLevelScore;

    public int score = 0;
    public MoveAndDetect moveAndDetectRef;
    public MyGameManager gameManager;

    public  NextLevelMenu nextLevelMenuRef;

    public string hearthTag = "hearth";
    public string obstacleTag = "obstacle";

     public Animator animator;


    // LEVEL TOPSCORE VE HIGHCORELARI

    public int nextLevelReq1 = 7;
    public int nextLevelReq2 = 8;
    public int nextLevelReq3 = 9;
    public int nextLevelReq4 = 9;
    public int nextLevelReq5 = 10;
    public int nextLevelReq6 = 10;

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
        if (currentLevel == 6)
        {
            highscore6 = PlayerPrefs.GetInt("highscore6");
        }
    
        
        /*
        highscore1 = 1;
        highscore2 = 1;
        highscore3 = 1;
        highscore4 = 1;    
        highscore5 = 1;
        highscore6 = 1;
        PlayerPrefs.SetInt("highscore1", 1);
        PlayerPrefs.SetInt("highscore2", 1);
        PlayerPrefs.SetInt("highscore3", 1);
        PlayerPrefs.SetInt("highscore4", 1);
        PlayerPrefs.SetInt("highscore5", 1);
        PlayerPrefs.SetInt("highscore6", 1);
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

    public  void WalkSpeedInc() {
        moveAndDetectRef.moveSpeed += 1f;
    }

   

    // assign hearth and obstacle missions
    private void OnTriggerEnter2D(Collider2D other) {
        
        if (other.gameObject.tag == hearthTag)
        {

            FindObjectOfType<AudioManager>().PitchInc("Walking");
            FindObjectOfType<AudioManager>().Play("Collect");
   
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
                
                
                
                 if (highscore1 >= (nextLevelReq1 +1) && currentLevel >= PlayerPrefs.GetInt("levelAt"))
                {

                        nextLevelLoad = currentLevel + 1;
                        PlayerPrefs.SetInt("levelAt", nextLevelLoad);

                }
                
                Debug.Log("nextLevelLoad is :" + nextLevelLoad);
                Debug.Log("levelAt is :" + PlayerPrefs.GetInt("levelAt"));

                if (score>=11)
                {
                    NextLevelMenuOpened();
                }

            }
            //LEVEL 2
            if (currentLevel == 2)
            {
                
                 if (score > highscore2)
                {
                    highscore2 = score;
                    PlayerPrefs.SetInt("highscore2", highscore2);
                }
                
                
                
                 if (highscore2 >= nextLevelReq2 +1  && currentLevel >= PlayerPrefs.GetInt("levelAt"))
                {

                        nextLevelLoad = currentLevel + 1;
                        PlayerPrefs.SetInt("levelAt", nextLevelLoad);
                        
                }
                if (score>=11)
                {
                    NextLevelMenuOpened();
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
                
                
                
                 if (highscore3 >= nextLevelReq3 + 1 && currentLevel >= PlayerPrefs.GetInt("levelAt"))
                {
                    
                        nextLevelLoad = currentLevel + 1;
                        PlayerPrefs.SetInt("levelAt", nextLevelLoad);
                    
                }
                if (score>=11)
                {
                    
                    NextLevelMenuOpened();
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
                
                
                
                 if (highscore4 >= nextLevelReq4+1 && currentLevel >= PlayerPrefs.GetInt("levelAt"))
                {
                    
                    
    
                        nextLevelLoad = currentLevel + 1;
                        PlayerPrefs.SetInt("levelAt", nextLevelLoad);
                        
                    
                }

                if (score>=11)
                {
                    
                    NextLevelMenuOpened();
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
                
                
                
                 if (highscore5 >= nextLevelReq5+1 && currentLevel >= PlayerPrefs.GetInt("levelAt"))
                {
                    
 
                        nextLevelLoad = currentLevel + 1;
                        PlayerPrefs.SetInt("levelAt", nextLevelLoad);
                        
                    
                }
                if (score>=11)
                {
                    
                    NextLevelMenuOpened();
                }
            }
            //LEVEL6
            if (currentLevel == 6)
            {
                
                 if (score > highscore6)
                {
                    highscore6 = score;
                    PlayerPrefs.SetInt("highscore6", highscore6);
                }
                
                
                
                 if (highscore6 >= nextLevelReq6+1 && currentLevel >= PlayerPrefs.GetInt("levelAt"))
                {
                    
 
                        //nextLevelLoad = currentLevel + 1;
                        //PlayerPrefs.SetInt("levelAt", nextLevelLoad);
                        
                    
                }
                if (score>=11)
                {
                    
                    DeathMenuOpened();
                }
            }
            
            // VELO INC BY COLLECT
            if (score <= 7)
            {
                Invoke("WalkSpeedInc",0.5f);
            }

        }

       

        if (other.gameObject.tag == obstacleTag)
        {
            DeathMenuOpened();
        }

        

        
    }
    
    void DeathMenuOpened (){

            animator.SetBool("Dead", true);
            if (currentLevel == 1) {
                levelScore.text = (highscore1-1).ToString();
                EndScoreText.text = (score-1).ToString();
            }
            if (currentLevel == 2) {
                levelScore.text = (highscore2-1).ToString();
                EndScoreText.text = (score-1).ToString();
            }
            if (currentLevel == 3) {
                levelScore.text = (highscore3-1).ToString();
                EndScoreText.text = (score-1).ToString();
            }
            if (currentLevel == 4) {
                levelScore.text = (highscore4-1).ToString();
                EndScoreText.text = (score-1).ToString();
            }
            if (currentLevel == 5) {
                levelScore.text = (highscore5-1).ToString();
                EndScoreText.text = (score-1).ToString();
            }
            if (currentLevel == 6) {
                levelScore.text = (highscore6-1).ToString();
                EndScoreText.text = (score-1).ToString();
            }
            
            // SOUND STUFF
            FindObjectOfType<AudioManager>().Play("Player Death");
            FindObjectOfType<AudioManager>().Stop("Walking");
            
            gameManager.DeathAnimAndStopCharacter();
        }

        public void NextLevelMenuOpened() {

            if (currentLevel == 1) {
                NextLevelHighScore.text = (highscore1-1).ToString();
                NextLevelScore.text = (score-1).ToString();
            }
            if (currentLevel == 2) {
                NextLevelHighScore.text = (highscore2-1).ToString();
                NextLevelScore.text = (score-1).ToString();
            }
            if (currentLevel == 3) {
                NextLevelHighScore.text = (highscore3-1).ToString();
                NextLevelScore.text = (score-1).ToString();
            }
            if (currentLevel == 4) {
                NextLevelHighScore.text = (highscore4-1).ToString();
                NextLevelScore.text = (score-1).ToString();
            }
            if (currentLevel == 5) {
                NextLevelHighScore.text = (highscore5-1).ToString();
                NextLevelScore.text = (score-1).ToString();
            }
            if (currentLevel == 6) {
                NextLevelHighScore.text = (highscore6-1).ToString();
                NextLevelScore.text = (score-1).ToString();
            }
            nextLevelMenuRef.OpenNextLevelMenu();
            Time.timeScale = 0f;
        }
}

