using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyJudge : MonoBehaviour
{
    public bool isJudge = false;
    public GameObject note;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (name.Substring(4).Equals("FailCollider"))
        {

        }
        if (other.tag == "Note")
        {
            isJudge = true;
            note = other.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Note")
        {
            isJudge = false;
        }
    }
}
