using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelSelect : MonoBehaviour
{

    public GameObject LoadingScreen;
    
    public int level;
    public TextMeshProUGUI levelText;

    public void Start() {


    levelText.text = level.ToString();
        
    }

    public void OpenScene() {
        //SceneManager.LoadScene("Level" + level.ToString());

        StartCoroutine(LoadSceneAsync());
    }

    IEnumerator LoadSceneAsync () {

        AsyncOperation operation = SceneManager.LoadSceneAsync("Level" + level.ToString());

        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progressValue = Mathf.Clamp01(operation.progress/0.9f);
            //Slider.value = progressValue;

            yield return null;
        }
    }

}
