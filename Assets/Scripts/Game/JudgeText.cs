using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JudgeText : MonoBehaviour
{
   TMP_Text judgeText;
    void Start()
    {
        judgeText = GetComponent<TMP_Text>();
    }

    public void Set(char judgeString)
    {
        judgeText.enabled = true;
        switch(judgeString)
        {
            case 'P':
                judgeText.text = "Perfect!!";
                break;
            case 'G':
                judgeText.text = "Good!";
                break;
            case 'B':
                judgeText.text = "Bad";
                break;
            case 'F':
                judgeText.text = "Fail..";
                break;
        }
    }

}
