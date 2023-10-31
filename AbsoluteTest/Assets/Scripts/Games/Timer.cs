using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Timer : MonoBehaviour
{
    public GameObject readyTimerPanel;
    public TMP_Text readyTimer;
    public int readyTime;

    void Awake() {
        readyTime = 3;
        StartCoroutine(ReadyTimer());
    }

    IEnumerator ReadyTimer() {
        readyTimerPanel.SetActive(true);
        for(;readyTime>0;readyTime--) {
            readyTimer.text = readyTime.ToString();
            yield return new WaitForSeconds(1f);
        }
        readyTimerPanel.SetActive(false);
    }



}
