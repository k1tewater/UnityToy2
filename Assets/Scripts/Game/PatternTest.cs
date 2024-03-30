using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PatternTest : MonoBehaviour
{
    const float D = -1.5f, F = -0.5f, J = 0.5f, K = 1.5f;

    GameObject note;
    void Start()
    {
        note = Resources.Load<GameObject>("Prefabs/Note");
        var patternCode = new Pattern(Define.Tracks.Nightmare).code;

        foreach(float[] value in patternCode)
        {
            SetNote(value[0], value[1]);
        }
    }

    void SetNote(float keyValue, float yPos)
    {
        var noteObj = Instantiate(note, transform);
        noteObj.transform.localPosition = new Vector3(keyValue, yPos);
        noteObj.GetComponent<SpriteRenderer>().sortingOrder--;
    }

}
