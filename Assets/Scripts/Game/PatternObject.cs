using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PatternObject : MonoBehaviour
{
    const float D = -1.5f, F = -0.5f, J = 0.5f, K = 1.5f;
    float speed;
    GameObject note;
    string patternMakeTest = "";
    void Start()
    {
        note = Resources.Load<GameObject>("Prefabs/Note");
        var patternCode = new Pattern(Define.Tracks.Nightmare).code;

        foreach(float[] value in patternCode)
        {
            SetNote(value[0], value[1]);
        }

        speed = 5f;
    }

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        
        if(Input.GetKeyDown(KeyCode.D))
        {
            patternMakeTest += $"D{-transform.position.y-2} ";
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            patternMakeTest += $"F{-transform.position.y-2} ";
        }
        if(Input.GetKeyDown(KeyCode.J))
        {
            patternMakeTest += $"J{-transform.position.y-2} ";
        }
        if(Input.GetKeyDown(KeyCode.K))
        {
            patternMakeTest += $"K{-transform.position.y-2} ";
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            string[] splited = patternMakeTest.TrimEnd().Split(' ');
            string[] output = new string[splited.Length];
            for (int i = 0; i < splited.Length; i++)
            {
                string part = splited[i];
                string firstChar = splited[0];
                string number = part.Substring(1);

                // 소수점 제거
                int dotIndex = number.IndexOf('.');
                if (dotIndex != -1)
                {
                    number = number.Substring(0, dotIndex);
                }

                // 반올림
                int roundedNumber = int.Parse(number) + (number[number.Length - 1] >= '5' ? 1 : 0);

                // 출력 문자열 구성
                output[i] = firstChar + roundedNumber.ToString();
            }
            Debug.Log(string.Join(' ', output));
        }
    }

    private void SetNote(float keyValue, float yPos)
    {
        var noteObj = Instantiate(note, transform);
        noteObj.transform.localPosition = new Vector3(keyValue, yPos);
//        noteObj.GetComponent<SpriteRenderer>().sortingOrder--;
    }
}
