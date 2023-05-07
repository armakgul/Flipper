using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectManaer : MonoBehaviour
{

    public GameObject LoadingScreen;
    public Slider Slider;
    
    public void BacktoMainMenu(){
        StartCoroutine (LoadSceneAsync());
    }

    IEnumerator LoadSceneAsync () {

        AsyncOperation operation = SceneManager.LoadSceneAsync("EntraceMenu");

        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progressValue = Mathf.Clamp01(operation.progress/0.9f);
            //Slider.value = progressValue;

            yield return null;
        }
    }
}
