using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditorInternal;
using UnityEngine;

public class ObjectManager
{
    public GameObject[] keys = {
        GameObject.Find("Key1"),
        GameObject.Find("Key2"),
        GameObject.Find("Key3"),
        GameObject.Find("Key4")
    };
    public Combo combo =GameObject.Find("Combo").GetComponent<Combo>();
}
