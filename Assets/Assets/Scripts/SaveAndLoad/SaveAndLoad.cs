using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [System.Serializable]
public class SaveAndLoad
{
    public int highscore;

    public SaveAndLoad (CollectAndDie inGameData) {  
        highscore = inGameData.highscore; 
    }
}
