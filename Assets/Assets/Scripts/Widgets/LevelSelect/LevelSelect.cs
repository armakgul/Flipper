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

        

        if (level == 5 || level == 6)
        {
            levelText.text = "COMING SOON".ToString();
        } else levelText.text = level.ToString();

    }

    public void OpenScene() {
        SceneManager.LoadScene("Level" + level.ToString());
    }

}
