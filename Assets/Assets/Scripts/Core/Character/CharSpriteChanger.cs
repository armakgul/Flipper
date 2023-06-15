using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSpriteChanger : MonoBehaviour
{
    public GameObject character;

    public Sprite[] skins = new Sprite[6];

    int skinNumber;


    void Awake () {

        skinNumber = PlayerPrefs.GetInt("ShipTextureNumber");
    }

    void Start() {

         Debug.Log("name is : " + character.GetComponent<SpriteRenderer>().sprite.name);
        
        skinNumber = PlayerPrefs.GetInt("ShipTextureNumber",1);
        ChangeSkin(skinNumber);

    }


    public void ChangeSkin(int skin) {

        switch (skin) {

            case 6:
            character.GetComponent<SpriteRenderer>().sprite = skins[5];
            Debug.Log("gdfgsgsg");
            break;

            case 5:
            character.GetComponent<SpriteRenderer>().sprite = skins[4];
            break;

            case 4:
            character.GetComponent<SpriteRenderer>().sprite = skins[3];
            break;
            
            case 3:
            character.GetComponent<SpriteRenderer>().sprite = skins[2];
            break;

            case 2:
            character.GetComponent<SpriteRenderer>().sprite = skins[1];
            Debug.Log("gdfgsgsg");
            break;

            case 1:
            character.GetComponent<SpriteRenderer>().sprite = skins[0];
            break;

            default:
            character.GetComponent<SpriteRenderer>().sprite = skins[0];
            break;

            

        }

    }

}
