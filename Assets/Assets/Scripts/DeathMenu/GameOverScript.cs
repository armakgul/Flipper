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

    public void ShowInterstitial() {
        GoogleAdMobController.AdmobManager.ShowInterstitialAd();
    }

    public void RestartGame() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
