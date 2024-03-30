using System;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private const int PERFECT_SCORE = 300, GOOD_SCORE = 200, BAD_SCORE = 100;
    public long score {get{return _score;}}
    long _score;
    TMP_Text scoreText;
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        _score = 0;
    }
    public void Add(char judgeString)
    {
        int combo = ObjManager.GetInstance.comboText.combo;
        int judgeScore = -1;
        switch(judgeString)
        {
            case 'P':
                judgeScore = PERFECT_SCORE;
                break;
            case 'G':
                judgeScore = GOOD_SCORE;
                break;
            case 'B':
                judgeScore = BAD_SCORE;
                break;
        }
        _score += combo * judgeScore;
        SetText();
    }

    private void SetText()
    {
        scoreText.text = string.Format("Score\n<size=15/>{0:n}", _score.ToString());
    }
}
