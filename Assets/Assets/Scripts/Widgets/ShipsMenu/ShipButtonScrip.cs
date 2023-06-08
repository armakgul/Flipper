using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipButtonScrip : MonoBehaviour
{
    // bu buton bazı bilgiler tutacak ve tıklandığında üste aktaracak;
    // hangi texture ın karaktere atanması gerektiği ==> bir player prefte tutulacak, karakter başlangıcında bu preften texture seçilecek
    // ayrıca tıklandığında rewarded ad sayfasını açacak

    public int shipButtonNumber;

    public void ShipTextureSaving()
    {
        switch (shipButtonNumber)
        {
        case 6:
            PlayerPrefs.SetInt("ShipTextureNumber",6);
            DebugShipNumber(); 
            break;
        case 5:
            PlayerPrefs.SetInt("ShipTextureNumber",5);
            DebugShipNumber();  
            break;
        case 4:
            PlayerPrefs.SetInt("ShipTextureNumber",4);
            DebugShipNumber(); 
            break;
        case 3:
            PlayerPrefs.SetInt("ShipTextureNumber",3);
            DebugShipNumber(); 
            break;
        case 2:
            PlayerPrefs.SetInt("ShipTextureNumber",2);
            DebugShipNumber(); 
            break;
        case 1:
            PlayerPrefs.SetInt("ShipTextureNumber",1);
            DebugShipNumber(); 
            break;
        default:
            PlayerPrefs.SetInt("ShipTextureNumber",1);
            DebugShipNumber(); 
            break;
        }
    }

    public void DebugShipNumber () {
            Debug.Log(PlayerPrefs.GetInt("ShipTextureNumber"));
    }

    

}
