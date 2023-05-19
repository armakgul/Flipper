using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
   public int currentIndex;

    private void Awake() {
        this.gameObject.SetActive(false);
   }

   public  void Start() {
        currentIndex = SceneManager.GetActiveScene().buildIndex;
        this.gameObject.SetActive(true);
        
   }

   public void OpenContinueMenu() {
        Time.timeScale = 0f;
        FindObjectOfType<AudioManager>().Stop("Walking");
        this.gameObject.SetActive(true);
        
   }

   public void RestartLevel() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(currentIndex);
   }

   public void GoToMainMenu () {
        Time.timeScale = 1f;
        SceneManager.LoadScene("EntraceMenu");
   }

   public void ContinueLevel() {
        Time.timeScale = 1f;
        FindObjectOfType<AudioManager>().Play("Walking");
        this.gameObject.SetActive(false);
   }
}
