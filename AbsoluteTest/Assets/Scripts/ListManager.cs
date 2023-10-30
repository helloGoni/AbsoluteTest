using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ListManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject[] stage;
    public TMP_Text totalStarText;

    public void Setting() {
        int type = SaveManager.instance.gameType;
        for(int i = 0 ; i < stage.Length; i++ ) {
            stage[i].GetComponent<StageSelecter>().Setup(i+1,SaveManager.instance.data.gameData[type,i+1]);
        }
        int totalStar = SaveManager.instance.CalTotalStar();
        totalStarText.text = $"{totalStar} / 60";
    }

}
