using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StageSelecter : MonoBehaviour
{
    public TMP_Text stageNumText;
    public Image starImage;
    public Sprite zeroStar, oneStar, twoStar, threeStar;

    public void Setup(int stageNum, int count) {
        stageNumText.text = stageNum.ToString();
        switch(count) {
            case 0:
                starImage.sprite = zeroStar;
                break;
            case 1:
                starImage.sprite = oneStar;
                break;
            case 2:
                starImage.sprite = twoStar;
                break;
            case 3:
                starImage.sprite = threeStar;
                break;
            default:
                break;
        }
    }
}
