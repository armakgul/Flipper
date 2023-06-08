using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipsMenu : MonoBehaviour
{
    public GameObject shipsCanvas;

    public GameObject rewardedCanvas;

    //public GameObject character;


    void Start () {

        shipsCanvas.SetActive(false);
        rewardedCanvas.SetActive(false);
        
    }

    public void OpensShipsMenu() {
        
        shipsCanvas.SetActive(true);
        

    }

    public void CloseShipsMenu() {

        shipsCanvas.SetActive(false);

    }

    public void OpenRewardedCanvas () {
        rewardedCanvas.SetActive(true);
    }

    // rewarded ads gössterildikten hemen sonra çağrılcak
    // menüyü kapatacak
    // ships menüsüne döndürecek. Zaten açık olcağı için rewardedcanvas ı kapatsa yeter
    public void CloseRewardedCanvas () {
        rewardedCanvas.SetActive(false);
    }

    public void PlayRewardedAd() {

        //playRewardedAd fonksyionu çağrılcak
        //ad bitiminde seçili ve kayıtlı karakter texture i değişecek, kaydedilecek
        //bu sprite değerini buttondan alacak
        //buttonlar üzerlerinde bir sayı tutacak
        //bu scriptte bu sayı değeri üzerinden texture ve başka bir sayı tutulacak

        
        
    }
}

