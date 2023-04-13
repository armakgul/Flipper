using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject optionsMenu;

    private void Start() {
        CloseOptionsMenu();
    }

    public void GoToLevelSelector() {
        SceneManager.LoadScene("LevelSelector");
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void GoToTheLastLevel () {
        SceneManager.LoadScene("Level1");
    }

    public void OpenOptionsMenu () {
        optionsMenu.SetActive(true);
    }
    public void CloseOptionsMenu () {
        optionsMenu.SetActive(false);
    }

    public void CloseSounds() {

    }

    public void PlayRewardedAd() {

    }


}
