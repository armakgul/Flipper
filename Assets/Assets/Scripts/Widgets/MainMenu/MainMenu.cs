using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public GameObject optionsMenu;
    public Animator sliderAnimator;

    private void Start() {
        CloseOptionsMenu();
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


    public void CloseSounds() {

    }

    public void PlayRewardedAd() {

    }

    public void SliderButtonReverse() {
        
        if (sliderAnimator.GetBool("playClose") == false)
        {
            sliderAnimator.SetBool("playClose",true);
            sliderAnimator.SetBool("playOpen",false);

        } else {
            sliderAnimator.SetBool("playClose",false);
            sliderAnimator.SetBool("playOpen",true);
        }

        
    }

}
