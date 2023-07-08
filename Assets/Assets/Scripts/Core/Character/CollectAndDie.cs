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

     public NextLevelStars nextLevelBackground;

     public GameObject character;

     public Sprite wreckSprite;


    // LEVEL TOPSCORE VE HIGHCORELARI

    public int nextLevelReq1 = 7;
    public int nextLevelReq2 = 8;
    public int nextLevelReq3 = 9;
    public int nextLevelReq4 = 9;
    public int nextLevelReq5 = 10;
    public int nextLevelReq6 = 10;

    //chapter2
    public int nextLevelReq7 = 10;
    public int nextLevelReq8 = 10;
    public int nextLevelReq9 = 10;
    public int nextLevelReq10 = 10;
    public int nextLevelReq11 = 10;
    public int nextLevelReq12 = 10;

    private int nextLevelScore = 11;

    public int nextLevelLoad;
    public int currentLevel;
    public int highscore1;
    public int highscore2;
    public int highscore3;
    public int highscore4;
    public int highscore5;
    public int highscore6;

    //chapter2
    public int highscore7;
    public int highscore8;
    public int highscore9;
    public int highscore10;
    public int highscore11;
    public int highscore12;

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
        if (currentLevel == 7)
        {
            highscore6 = PlayerPrefs.GetInt("highscore7");
        }
        if (currentLevel == 8)
        {
            highscore6 = PlayerPrefs.GetInt("highscore8");
        }
        if (currentLevel == 9)
        {
            highscore6 = PlayerPrefs.GetInt("highscore9");
        }
        if (currentLevel == 10)
        {
            highscore6 = PlayerPrefs.GetInt("highscore10");
        }
        if (currentLevel == 11)
        {
            highscore6 = PlayerPrefs.GetInt("highscore11");
        }
        if (currentLevel == 12)
        {
            highscore6 = PlayerPrefs.GetInt("highscore12");
        }
    
        
        /*
        highscore1 = 1;
        highscore2 = 1;
        highscore3 = 1;
        highscore4 = 1;    
        highscore5 = 1;
        highscore6 = 1;
        highscore7 = 1;
        highscore8 = 1;
        highscore9 = 1;
        highscore10 = 1;
        highscore11 = 1;
        highscore12 = 1;
        PlayerPrefs.SetInt("highscore1", 1);
        PlayerPrefs.SetInt("highscore2", 1);
        PlayerPrefs.SetInt("highscore3", 1);
        PlayerPrefs.SetInt("highscore4", 1);
        PlayerPrefs.SetInt("highscore5", 1);
        PlayerPrefs.SetInt("highscore6", 1);
        PlayerPrefs.SetInt("highscore7", 1);
        PlayerPrefs.SetInt("highscore8", 1);
        PlayerPrefs.SetInt("highscore9", 1);
        PlayerPrefs.SetInt("highscore10", 1);
        PlayerPrefs.SetInt("highscore11", 1);
        PlayerPrefs.SetInt("highscore12", 1);

        

        Debug.Log("highscore1 is : " + highscore1);
        Debug.Log("highscore2 is : " + highscore2);
        Debug.Log("highscore3 is : " + highscore3);
        Debug.Log("highscore4 is : " + highscore4);
        Debug.Log("highscore5 is : " + highscore5);
        Debug.Log("highscore6 is : " + highscore6);
        */
        

        // PLAY WALKING EFFECT
        FindObjectOfType<AudioManager>().Play("Walking");

        //GoogleAdMobController.AdmobManager.RequestAndLoadInterstitialAd();


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

            Debug.Log(score);
            
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

                if (score>=nextLevelScore)
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
                if (score>=nextLevelScore)
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
                if (score>=nextLevelScore)
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

                if (score>=nextLevelScore)
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
                if (score>=nextLevelScore)
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
                    
 
                        nextLevelLoad = currentLevel + 1;
                        PlayerPrefs.SetInt("levelAt", nextLevelLoad);
                        
                    
                }
                if (score>=nextLevelScore)
                {
                    
                    NextLevelMenuOpened();
                }
            }
            //LEVEL 7
            if (currentLevel == 7)
            {
                
                 if (score > highscore7)
                {
                    highscore7 = score;
                    PlayerPrefs.SetInt("highscore7", highscore7);
                }
                
                
                
                 if (highscore7 >= nextLevelReq7+1 && currentLevel >= PlayerPrefs.GetInt("levelAt"))
                {
                    
 
                        nextLevelLoad = currentLevel + 1;
                        PlayerPrefs.SetInt("levelAt", nextLevelLoad);
                        
                    
                }
                if (score>=nextLevelScore)
                {
                    
                    NextLevelMenuOpened();
                }
            }
            
            //LEVEL 8
            if (currentLevel == 8)
            {
                if (score > highscore8)
                {
                    highscore8 = score;
                    PlayerPrefs.SetInt("highscore8", highscore8);
                }
                
                if (highscore8 >= nextLevelReq8+1 && currentLevel >= PlayerPrefs.GetInt("levelAt"))
                {
                    nextLevelLoad = currentLevel + 1;
                    PlayerPrefs.SetInt("levelAt", nextLevelLoad);               
                }
                
                if (score>=nextLevelScore)
                {
                    NextLevelMenuOpened();
                }
            }

            //LEVEL 9
            if (currentLevel == 9)
            {
                if (score > highscore9)
                {
                    highscore9 = score;
                    PlayerPrefs.SetInt("highscore9", highscore9);
                }
                
                if (highscore9 >= nextLevelReq9+1 && currentLevel >= PlayerPrefs.GetInt("levelAt"))
                {
                    nextLevelLoad = currentLevel + 1;
                    PlayerPrefs.SetInt("levelAt", nextLevelLoad);               
                }
                
                if (score>=nextLevelScore)
                {
                    NextLevelMenuOpened();
                }
            }

            //LEVEL 10
            if (currentLevel == 10)
            {
                if (score > highscore10)
                {
                    highscore10 = score;
                    PlayerPrefs.SetInt("highscore10", highscore10);
                }
                
                if (highscore10 >= nextLevelReq10+1 && currentLevel >= PlayerPrefs.GetInt("levelAt"))
                {
                    nextLevelLoad = currentLevel + 1;
                    PlayerPrefs.SetInt("levelAt", nextLevelLoad);               
                }
                
                if (score>=nextLevelScore)
                {
                    NextLevelMenuOpened();
                }
            }
            //LEVEL 11
            if (currentLevel == 11)
            {
                if (score > highscore11)
                {
                    highscore11 = score;
                    PlayerPrefs.SetInt("highscore11", highscore11);
                }
                
                if (highscore11 >= nextLevelReq11+1 && currentLevel >= PlayerPrefs.GetInt("levelAt"))
                {
                    nextLevelLoad = currentLevel + 1;
                    PlayerPrefs.SetInt("levelAt", nextLevelLoad);               
                }
                
                if (score>=nextLevelScore)
                {
                    NextLevelMenuOpened();
                }
            }

            //LEVEL 12
            if (currentLevel == 12)
            {
                if (score > highscore12)
                {
                    highscore12 = score;
                    PlayerPrefs.SetInt("highscore12", highscore12);
                }
                
                if (highscore12 >= nextLevelReq12+1 && currentLevel >= PlayerPrefs.GetInt("levelAt"))
                {
                    //nextLevelLoad = currentLevel + 1;
                    //PlayerPrefs.SetInt("levelAt", nextLevelLoad);               
                }
                
                if (score>=nextLevelScore)
                {
                    NextLevelMenuOpened();
                }
            }








            
            // VELO INC BY COLLECT
            if (score <= 7)
            {
                Invoke("WalkSpeedInc",0.5f);
            }

        }

       
        //  NEXTLEVELLOAD DAN KUCUKSE DEATH; YÜKSEKSE NEXTLEVELMENU
        if (other.gameObject.tag == obstacleTag)
        {
            if (currentLevel == 1)
            {
                if (score<nextLevelReq1+1)
                {
                    DeathMenuOpened();
                }else
                {
                    NextLevelMenuOpened();
                }
            }

            if (currentLevel == 2)
            {
                if (score<nextLevelReq2+1)
                {
                    DeathMenuOpened();
                }else
                {
                    NextLevelMenuOpened();
                }
            }

            if (currentLevel == 3)
            {
                if (score<nextLevelReq3+1)
                {
                    DeathMenuOpened();
                }else
                {
                    NextLevelMenuOpened();
                }
            }

            if (currentLevel == 4)
            {
                if (score<nextLevelReq4+1)
                {
                    DeathMenuOpened();
                }else
                {
                    NextLevelMenuOpened();
                }
            }

            if (currentLevel == 5)
            {
                if (score<nextLevelReq5+1)
                {
                    DeathMenuOpened();
                }else
                {
                    NextLevelMenuOpened();
                }
            }

            if (currentLevel == 6)
            {
                if (score<nextLevelReq6+1)
                {
                    DeathMenuOpened();
                }else
                {
                    NextLevelMenuOpened();
                }
            }
            if (currentLevel == 7)
            {
                if (score < nextLevelReq7+1)
                {
                    DeathMenuOpened();
                }
                else
                {
                    NextLevelMenuOpened();
                }
            }
            if (currentLevel == 8)
            {
                if (score < nextLevelReq8+1)
                {
                    DeathMenuOpened();
                }
                else
                {
                    NextLevelMenuOpened();
                }
            }

            if (currentLevel == 9)
            {
                if (score < nextLevelReq9+1)
                {
                    DeathMenuOpened();
                }
                else
                {
                    NextLevelMenuOpened();
                }
            }

            if (currentLevel == 10)
            {
                if (score < nextLevelReq10+1)
                {
                    DeathMenuOpened();
                }
                else
                {
                    NextLevelMenuOpened();
                }
            }

            if (currentLevel == 11)
            {
                if (score < nextLevelReq11+1)
                {
                    DeathMenuOpened();
                }
                else
                {
                    NextLevelMenuOpened();
                }
            }

            if (currentLevel == 12)
            {
                if (score < nextLevelReq12+1)
                {
                    DeathMenuOpened();
                }
                else
                {
                    DeathMenuOpened();
                }
            }


        

        
        }
    }
    
    void DeathMenuOpened (){

            animator.SetBool("Dead", true);

            character.GetComponent<SpriteRenderer>().sprite = wreckSprite;

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
            if (currentLevel == 7) {
                levelScore.text = (highscore7-1).ToString();
                EndScoreText.text = (score-1).ToString();
            }
            if (currentLevel == 8) {
                levelScore.text = (highscore8-1).ToString();
                EndScoreText.text = (score-1).ToString();
            }

            if (currentLevel == 9) {
                levelScore.text = (highscore9-1).ToString();
                EndScoreText.text = (score-1).ToString();
            }

            if (currentLevel == 10) {
                levelScore.text = (highscore10-1).ToString();
                EndScoreText.text = (score-1).ToString();
            }

            if (currentLevel == 11) {
                levelScore.text = (highscore11-1).ToString();
                EndScoreText.text = (score-1).ToString();
            }

            if (currentLevel == 12) {
                levelScore.text = (highscore12-1).ToString();
                EndScoreText.text = (score-1).ToString();
            }


            
            // SOUND STUFF
            FindObjectOfType<AudioManager>().Play("Player Death");
            FindObjectOfType<AudioManager>().Stop("Walking");
            
            gameManager.DeathAnimAndStopCharacter();


        // Admob vs unity check
        if (GoogleAdMobController.AdmobManager.admobInterstitialAd != null)
        {
            GoogleAdMobController.AdmobManager.ShowInterstitialAd();
        } else InterstitialAdsButton.unityAdsInterstitial.ShowAd();
            
            
        }

        public void NextLevelMenuOpened() {

            if (currentLevel == 1) {
                NextLevelHighScore.text = (highscore1-1).ToString();
                NextLevelScore.text = (score-1).ToString();

                if (score>=10)
                {
                    nextLevelBackground.SpriteChanging(3);
                } else if (score >= nextLevelReq1)
                {nextLevelBackground.SpriteChanging(2);
                } else
                {
                   nextLevelBackground.SpriteChanging(1); 
                }

                
            }
            if (currentLevel == 2) {
                NextLevelHighScore.text = (highscore2-1).ToString();
                NextLevelScore.text = (score-1).ToString();

                 if (score>=10)
                {
                    nextLevelBackground.SpriteChanging(3);
                } else if (score >= nextLevelReq2)
                {nextLevelBackground.SpriteChanging(2);
                } else
                {
                   nextLevelBackground.SpriteChanging(1); 
                }
            }
            if (currentLevel == 3) {
                NextLevelHighScore.text = (highscore3-1).ToString();
                NextLevelScore.text = (score-1).ToString();

                 if (score>=10)
                {
                    nextLevelBackground.SpriteChanging(3);
                } else if (score >= nextLevelReq3)
                {nextLevelBackground.SpriteChanging(2);
                } else
                {
                   nextLevelBackground.SpriteChanging(1); 
                }
            }
            if (currentLevel == 4) {
                NextLevelHighScore.text = (highscore4-1).ToString();
                NextLevelScore.text = (score-1).ToString();

                 if (score>=10)
                {
                    nextLevelBackground.SpriteChanging(3);
                } else if (score >= nextLevelReq4)
                {nextLevelBackground.SpriteChanging(2);
                } else
                {
                   nextLevelBackground.SpriteChanging(1); 
                }
            }
            if (currentLevel == 5) {
                NextLevelHighScore.text = (highscore5-1).ToString();
                NextLevelScore.text = (score-1).ToString();

                 if (score>=10)
                {
                    nextLevelBackground.SpriteChanging(3);
                } else if (score >= nextLevelReq5)
                {nextLevelBackground.SpriteChanging(2);
                } else
                {
                   nextLevelBackground.SpriteChanging(1); 
                }
            }
            if (currentLevel == 6) {
                NextLevelHighScore.text = (highscore6-1).ToString();
                NextLevelScore.text = (score-1).ToString();

                 if (score>=10)
                {
                    nextLevelBackground.SpriteChanging(3);
                } else if (score >= nextLevelReq6)
                {nextLevelBackground.SpriteChanging(2);
                } else
                {
                   nextLevelBackground.SpriteChanging(1); 
                }
            }
            if (currentLevel == 7) {
                NextLevelHighScore.text = (highscore7-1).ToString();
                NextLevelScore.text = (score-1).ToString();

                if (score>=10) {
                    nextLevelBackground.SpriteChanging(3);
                } else if (score >= nextLevelReq7) {
                    nextLevelBackground.SpriteChanging(2);
                } else {
                nextLevelBackground.SpriteChanging(1); 
                }
            }

            if (currentLevel == 8) {
                NextLevelHighScore.text = (highscore8-1).ToString();
                NextLevelScore.text = (score-1).ToString();

                if (score>=10) {
                    nextLevelBackground.SpriteChanging(3);
                } else if (score >= nextLevelReq8) {
                    nextLevelBackground.SpriteChanging(2);
                } else {
                nextLevelBackground.SpriteChanging(1); 
                }
            }

            if (currentLevel == 9) {
                NextLevelHighScore.text = (highscore9-1).ToString();
                NextLevelScore.text = (score-1).ToString();

                if (score>=10) {
                    nextLevelBackground.SpriteChanging(3);
                } else if (score >= nextLevelReq9) {
                    nextLevelBackground.SpriteChanging(2);
                } else {
                nextLevelBackground.SpriteChanging(1); 
                }
            }

            if (currentLevel == 10) {
                NextLevelHighScore.text = (highscore10-1).ToString();
                NextLevelScore.text = (score-1).ToString();

                if (score>=10) {
                    nextLevelBackground.SpriteChanging(3);
                } else if (score >= nextLevelReq10) {
                    nextLevelBackground.SpriteChanging(2);
                } else {
                nextLevelBackground.SpriteChanging(1); 
                }
            }

            if (currentLevel == 11) {
                NextLevelHighScore.text = (highscore11-1).ToString();
                NextLevelScore.text = (score-1).ToString();

                if (score>=10) {
                    nextLevelBackground.SpriteChanging(3);
                } else if (score >= nextLevelReq11) {
                    nextLevelBackground.SpriteChanging(2);
                } else {
                nextLevelBackground.SpriteChanging(1); 
                }
            }

            if (currentLevel == 12) {
                NextLevelHighScore.text = (highscore12-1).ToString();
                NextLevelScore.text = (score-1).ToString();

                if (score>=10) {
                    nextLevelBackground.SpriteChanging(3);
                } else if (score >= nextLevelReq12) {
                    nextLevelBackground.SpriteChanging(2);
                } else {
                nextLevelBackground.SpriteChanging(1); 
                }
            }





            nextLevelMenuRef.OpenNextLevelMenu();
            FindObjectOfType<AudioManager>().Stop("Walking");
            Time.timeScale = 0f;
        }
    
}

