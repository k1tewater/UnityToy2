using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Pattern
{
    public LinkedList<float[]> code { get; } // [[key, ypos], [key, ypos] ...]

    public Pattern(Define.Tracks track)
    {
        code = new LinkedList<float[]>();

        string[] codeArr = GetCodeString(track).Split(' ');
        foreach (string value in codeArr)
        {
            float key = GetKey(value[0]);
            float yPos = float.Parse(value.Substring(1));
            Debug.Log(key + " " + yPos);
            code.AddLast(new float[] { key, yPos });
        }
    }

    private string GetCodeString(Define.Tracks track)
    {
        String codeString = "";
        switch (track)
        {
            case Define.Tracks.Nightmare:
                codeString =
                "D1 F2 J3 K4 D5 F6 J7 K8 D9 F10 J11 K12 D13 F14";
                break;
        }
        return codeString;
    }

    private float GetKey(char c)
    {
        switch (c)
        {
            case 'D':
                return -1.5f;
            case 'F':
                return -0.5f;
            case 'J':
                return 0.5f;
            case 'K':
                return 1.5f;
            default:
                return 0f;
        }
    }
}
