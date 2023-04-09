using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    public MoveAndDetect moveAndDetectRef;
    
    public void DeathAnimAndStopCharacter () {
        
        moveAndDetectRef.moveSpeed = 0f;
        Invoke("OpenDeadMenu", 1.0f);

        
    }

    void OpenDeadMenu() {
        Debug.Log("death menu opened");
        ShowInterstitial();
    }

    void ShowInterstitial() {
        GoogleAdMobController.AdmobManager.ShowInterstitialAd();
    }
}
