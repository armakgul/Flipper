using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    
    public Button[] lvlButtons;
    void Start()
    {
        PlayerPrefs.SetInt("levelAt" , 1);
        int levelAt = PlayerPrefs.GetInt("levelAt", 1);

        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if (i+2 > levelAt)
            {
                lvlButtons[i].interactable = false;
            }else {
                lvlButtons[i].interactable = true;
            }
        }
    }

}
