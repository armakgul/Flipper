using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;

public class MainMenu : MonoBehaviour
{
    
    public GameObject optionsMenu;
    public Animator sliderAnimator;

    public GoogleAdMobController admanager;

   

    // START
    private void Start() {
        CloseOptionsMenu();
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
        admanager.ShowInterstitialAd();
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

}
