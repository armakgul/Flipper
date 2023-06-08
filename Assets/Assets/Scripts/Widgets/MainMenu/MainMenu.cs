using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;
using TMPro;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    
    public GameObject optionsMenu;
    public Animator sliderAnimator;
    public GoogleAdMobController admanager;
    public GameObject TutorialMenu;
    
    private bool isSoundOn = true;
    public Sprite soundTextureOn;
    public Sprite soundTextureOff;
    public Button soundButton;

    

   

    // START
    private void Start() {
        CloseOptionsMenu();
        CloseTutorialCanvas();
        FindObjectOfType<AudioManager>().PlayMainMenu("Music1");
    }
    

    //LEVEL SELECTOR
    public void GoToLevelSelector() {
        Invoke("LoadLevelSelector",0.1f);
    }
    private void LoadLevelSelector() {
        SceneManager.LoadScene("LevelSelector");
    }


    //LOAD LAST LEVEL
    public void GoToTheLastLevel () {
        Invoke("LoadLastScene",0.1f);
        
    }
     private void LoadLastScene() {
        SceneManager.LoadScene("Level1");
    }


    // QUIT GAME INA
    public void QuitGame() {
        Application.Quit();
    }
    
    

   
    // OPEN AND CLOSE OPTIONS MENU
    public void OpenOptionsMenu () {
        optionsMenu.SetActive(true);
    }
    public void InvokeCloseOptionsMenu () {
        Invoke("CloseOptionsMenu",0.1f);
    }
    private void CloseOptionsMenu() {
        optionsMenu.SetActive(false);
    }


    
    //PLAY REWARDED ADS
    public void PlayRewardedAd() {
        //GoogleAdMobController.AdmobManager.RequestAndLoadInterstitialAd();
        //GoogleAdMobController.AdmobManager.ShowInterstitialAd();
        //admanager.RequestAndLoadInterstitialAd();
        //admanager.ShowInterstitialAd();
    }




    //OPEN AND CLOSE SOUNDS
    public void SliderButtonReverse() {
        
        if (sliderAnimator.GetBool("playClose") == false)
        {
            sliderAnimator.SetBool("playClose",true);
            sliderAnimator.SetBool("playOpen",false);
            AudioListener.volume = 0;

        } else {
            sliderAnimator.SetBool("playClose",false);
            sliderAnimator.SetBool("playOpen",true);
            
            AudioListener.volume = 1;
        }

        
    }

    public void SoundChange() {
        if (isSoundOn)
        {
            AudioListener.volume = 0;
            soundButton.image.sprite = soundTextureOff;
            isSoundOn = false;


        }
        else {
            AudioListener.volume = 1;
            soundButton.image.sprite = soundTextureOn;
            isSoundOn = true;
        }
    }


    public void CloseTutorialCanvas() {

        TutorialMenu.SetActive(false);

    }
    public void OpenTutorialCanvas () {

        TutorialMenu.SetActive(true);

    }

}
