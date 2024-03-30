using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.UI;
using UnityEngine;

public class Combo : MonoBehaviour
{
    int combo;
    TextMeshPro self;
    void Start()
    {
        self = GetComponent<TextMeshPro>();
        combo = 0;
    }

    public void Add()
    {
        combo++;
        self.text = combo + " Combo";
    }
    public void Break()
    {
        combo = 0;
        self.text = combo + " Combo";
    }
}
