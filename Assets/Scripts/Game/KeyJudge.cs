using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyJudge : MonoBehaviour
{
    KeyCode key;
    char judgeString; // P(Perfect), G(Good), B(Bad), F(Fail)
    bool isJudge;
    GameObject judgeNote;

    void Start()
    {
        key = GetThisKey();
        judgeString = name[4];
    }

    void Update()
    {
        if (!isJudge) return;

         if (Input.GetKeyDown(key))
        {
            Destroy(judgeNote);
            switch(judgeString)   
            {
                case 'P':
                case 'G':
                case 'B':
                    ObjManager.GetInstance.comboText.Add();
                    ObjManager.GetInstance.judgeText.Set(judgeString);
                    ObjManager.GetInstance.scoreText.Add(judgeString);
                    break;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Note")
            return;
        if (judgeString=='F')
        {
            Destroy(other.gameObject);
            ObjManager.GetInstance.comboText.Break();
            ObjManager.GetInstance.judgeText.Set(judgeString);
            return;
        }

        isJudge = true;
        judgeNote = other.gameObject;
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.tag != "Note")
            return;

        isJudge = false;
        judgeNote = null;
    }

    KeyCode GetThisKey()
    {
        switch (name[3])
        {
            case '1':
                return KeyCode.D;
            case '2':
                return KeyCode.F;
            case '3':
                return KeyCode.J;
            case '4':
                return KeyCode.K;
            default:
                return KeyCode.None;
        }
    }
}
