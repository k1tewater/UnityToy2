using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FailCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        GameObject.Find("Combo").GetComponent<TMP_Text>().text = "0 Combo";
    }
}
