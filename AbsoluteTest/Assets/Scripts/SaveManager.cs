using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager instance = null;

    void Awake() {
        if(instance == null) {
            instance = this;
            LoadData();
            DontDestroyOnLoad(this.gameObject);
        } else {
            Destroy(this.gameObject);
        }

    }

    void Start() {
        gameType = 0;
        stage = 1;
    }

    public GameData data = new GameData();
    public string fileName = "AbsoulteData.json";
//안드로이드는 어디서하는지?
    #region json 불러오고 저장하기

    public void LoadData() {
        string filePath = Application.persistentDataPath+ "/"+fileName;

        if(File.Exists(filePath)) {
            string tempData = File.ReadAllText(filePath);
            data = JsonUtility.FromJson<GameData>(tempData);
            print("불러오기 성공");
        }
    }

    public void SaveData() {
        string jsonData = JsonUtility.ToJson(data,true);
        string filePath = Application.persistentDataPath+ "/"+fileName;

        File.WriteAllText(filePath,jsonData);
        print("저장완료");
    }

    #endregion

    #region 현재 스테이지 정보

    public int gameType; // 0 color 1 sound 2 speed 3 luck 4 time
    public int stage;
    
    public void SelectGameType(int i) {
        gameType = i;
    }
    public void SelectStage(int i) {
        stage = i;
    }
    public int CalTotalStar() {
        int starCount = 0;
        for(int t = 1 ; t <= 20 ; t++ ) {
            if(data.gameData[gameType,t] > 0)
                starCount += data.gameData[gameType,t];
        }
        return starCount;
    }
    #endregion

    #region 스테이지 데이터 저장

    public void GameOver(int value) {
        if(data.gameData[gameType,stage] < value) {
            data.gameData[gameType,stage] = value;
            if(data.gameData[gameType,stage+1] == -1)
                data.gameData[gameType,stage+1] = 0;
            SaveData();
        }

    }

    #endregion
    //https://yoonstone-games.tistory.com/43
}
