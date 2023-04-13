using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectManaer : MonoBehaviour
{
    public void BacktoMainMenu(){
        SceneManager.LoadScene("EntraceMenu");
    }
}
