using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class NextLevelStars : MonoBehaviour
{
    public Image backImage;
    public Sprite[] sprites = new Sprite[3];


    void Awake() {
        backImage = this.GetComponent<Image>();
    }

    public void SpriteChanging (int number) {

        switch (number)
        {
            
        case 3:
            backImage.sprite = sprites[2];
            break;
        case 2:
            backImage.sprite = sprites[1];
            break;
        case 1:
            backImage.sprite = sprites[0];
            break;
        default:
            backImage.sprite = sprites[2];
            break;
        }

    }
}
