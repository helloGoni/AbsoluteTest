using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class GameData {
    public int[ , ] gameData = new int[5,22];

    public GameData() {
        for(int i = 0 ; i < 5 ; i++) {
            for(int j = 2 ; j<21 ; j++) {
                gameData[i,j] = -1;
            }
            gameData[i,0] = 0;
            gameData[i,1] = 0;
        }

    }
}
