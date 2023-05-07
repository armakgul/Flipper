using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class NextLevelMenu : MonoBehaviour
{

    public GameObject inGameMenu;
    public GameObject nextLevelMenuUI;

    int currentSceneIndex;

    public  void Awake() {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        
    }

     public void OpenNextLevelMenu() {
        nextLevelMenuUI.SetActive(true);
        CloseInGameMenu();
        Time.timeScale = 0f;

    }

    public void CloseNextLevelMenu() {
        nextLevelMenuUI.SetActive(false);
    }

    public void CloseInGameMenu() {
        inGameMenu.SetActive(false);
    }

    public void RestartGame() {
        Time.timeScale = 1f;
        Invoke("LoadCurrentLevel",0.25f);
    }

    private void LoadCurrentLevel() {
        SceneManager.LoadScene(currentSceneIndex);
    }

     public void LoadNextLevel() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(currentSceneIndex+1);
    }

    public void GoToMainMenu() {
        Time.timeScale = 1f;
        SceneManager.LoadScene("EntraceMenu");
    }

}
