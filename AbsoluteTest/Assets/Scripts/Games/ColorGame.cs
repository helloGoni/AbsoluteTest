using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColorGame : MonoBehaviour
{
    public ResultPanel RP;
    int round = 1;
    int count = 0;
    int stage;

    public GameObject level1Panel, level2Panel, level3Panel;

    public GameObject[] level1;
    public GameObject[] level2;
    public GameObject[] level3; 


    void Start() {
        stage = SaveManager.instance.stage;
        round = 1;
        count = 0;
    }
    public void StartRound(int num) {
        int answerNum;
        if(stage <5) {
            level1Panel.SetActive(true);
        } else if (stage < 13) {
            level2Panel.SetActive(true);
        } else {
            level3Panel.SetActive(true);
        }

        Color answerColor = new Color(Random.value,Random.value,Random.value);
    }

    public void NextRound() {
        
    }

    public void ClickAnswer() {
        ++count;
        if(round == 5) {
            RP.CallResultPanel(count);
        } else {
            ++round;
            NextRound();
        }
    }

    public void ClickNoAnswer() {
        if(round == 5) {
            RP.CallResultPanel(count);
        } else {
            ++round;
            NextRound();
        }
    }
    

    
}
