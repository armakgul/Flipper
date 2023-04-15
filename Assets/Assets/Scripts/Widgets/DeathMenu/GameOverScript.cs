using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverScript : MonoBehaviour
{

    public GameObject gameOverMenuUI;
    int currentSceneIndex;

    public  void Awake() {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    

    public void OpenGameOverMenu() {
        gameOverMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Debug.Log("aha");
    }

    public void CloseGameOverMenu() {
        gameOverMenuUI.SetActive(false);
    }

    public void InvokeShowIntersititial() {
        Time.timeScale = 1f;
        Invoke("LoadShowInterstitial",.25f);
    }
    private void LoadShowInterstitial() {
        GoogleAdMobController.AdmobManager.ShowInterstitialAd();
    }

    //RESTART CURRENT LEVEL
    public void RestartGame() {
        Time.timeScale = 1f;
        Invoke("LoadCurrentLevel",0.25f);
    }

    private void LoadCurrentLevel() {
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
