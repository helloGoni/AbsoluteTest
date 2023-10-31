using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ResultPanel : MonoBehaviour
{
    public GameObject resultPanel;
    public TMP_Text resultStageText;
    public Image starImage;
    public Sprite zeroStar,oneStar,twoStar,threeStar;

    public void CallResultPanel(int count) {
        int stage = SaveManager.instance.stage;
        resultStageText.text = $"Stage {stage.ToString()}";
        SetStarImage(count);
        SaveManager.instance.GameOver(count);
        resultPanel.SetActive(true);
    }

    public void SetStarImage(int count) {
        switch (count) {
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

    public void BackBtn() {
        SceneManager.LoadScene("MainScene");
    }

}
