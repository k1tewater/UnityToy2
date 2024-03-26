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
    }

    // Update is called once per frame
    void Update()
    {
        self.text = combo + " Combo";
    }

    public void AddCombo()
    {
        combo++;
    }
}
