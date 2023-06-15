using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipsMenu : MonoBehaviour
{
    public GameObject shipsCanvas;

    public GameObject rewardedCanvas;
    
    public int shipButtonNumber;

    [SerializeField] RewardedAdsButton rewardedAdsButton;

    //public GameObject character;


    void Awake () {

        shipsCanvas.SetActive(false);
        rewardedCanvas.SetActive(false);
        
    }

    public void OpensShipsMenu() {
        
        shipsCanvas.SetActive(true);

        

    }

    public void CloseShipsMenu() {

        shipsCanvas.SetActive(false);

    }

    public void OpenRewardedCanvas (int number) {
        rewardedCanvas.SetActive(true);

        Debug.Log(number);

        shipButtonNumber = number;
    }

    // rewarded ads gössterildikten hemen sonra çağrılcak
    // menüyü kapatacak
    // ships menüsüne döndürecek. Zaten açık olcağı için rewardedcanvas ı kapatsa yeter
    public void CloseRewardedCanvas () {
        rewardedCanvas.SetActive(false);
    }

    public void PlayRewardedAd() {

       rewardedAdsButton.skinNumber = shipButtonNumber;        
        
    }

}

