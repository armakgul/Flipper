using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelSelect : MonoBehaviour
{
    
    public int level;
    public TextMeshProUGUI levelText;

    public void Start() {


    levelText.text = level.ToString();
        
    }

    public void OpenScene() {
        SceneManager.LoadScene("Level" + level.ToString());
    }

}
