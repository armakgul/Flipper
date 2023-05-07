using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    public MoveAndDetect moveAndDetectRef;
    public GameOverScript gameOver;
    public GameObject inGameMEnu;

    public NextLevelMenu nextLevelMenuRef;
    
    
    void Start() {
        gameOver.CloseGameOverMenu();
        nextLevelMenuRef.CloseNextLevelMenu();
        inGameMEnu.SetActive(true);
    }

    public void DeathAnimAndStopCharacter () {
        
        moveAndDetectRef.moveSpeed = 0f;
        Invoke("Dead", 1.0f);
        
        
    }

    public void Dead() {
        Debug.Log("death menu opened");
        gameOver.OpenGameOverMenu();
        
    }

    
}
