using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PatternTest : MonoBehaviour
{
    const float D = -1.5f, F = -0.5f, J = 0.5f, K = 1.5f;
    float[][] patternCode;
    GameObject note;
    void Start()
    {
        note = Resources.Load<GameObject>("Prefabs/Note");

        SetNote(D, 1);
        SetNote(D, 2);
        SetNote(D, 3);
        SetNote(D, 4);
        SetNote(D, 5);
        SetNote(D, 6);
        SetNote(D, 7);
    }

    void SetNote(float keyValue, float yPos)
    {
        Instantiate(note, transform).transform.localPosition = new Vector3(keyValue, yPos);
    }

}
