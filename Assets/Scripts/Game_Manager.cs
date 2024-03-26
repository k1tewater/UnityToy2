using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    GameObject[] keys = new GameObject[4];
    Animation[] anim_keys = new Animation[4];
    GameObject pattern;

    TextMeshPro combo;

    // Start is called before the first frame update
    void Start()
    {
        keys[0] = GameObject.Find("Key1");
        keys[1] = GameObject.Find("Key2");
        keys[2] = GameObject.Find("Key3");
        keys[3] = GameObject.Find("Key4");

        anim_keys[0] = keys[0].GetComponent<Animation>();
        anim_keys[1] = keys[1].GetComponent<Animation>();
        anim_keys[2] = keys[2].GetComponent<Animation>();
        anim_keys[3] = keys[3].GetComponent<Animation>();

        combo = GameObject.Find("Combo").GetComponent<TextMeshPro>();

        PatternInstantiate();
    }

    // Update is called once per frame
    void Update()
    {
        KeyUpdate();
        NoteUpdate();
    }

    private void KeyUpdate()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim_keys[0].Play("KeyPressed");
            KeyJudging("Key1");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            anim_keys[1].Play("KeyPressed");
            KeyJudging("Key2");
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            anim_keys[2].Play("KeyPressed");
            KeyJudging("Key3");
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            anim_keys[3].Play("KeyPressed");
            KeyJudging("Key4");
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim_keys[0].Play("KeyUnpressed");
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            anim_keys[1].Play("KeyUnpressed");
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            anim_keys[2].Play("KeyUnpressed");
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            anim_keys[3].Play("KeyUnpressed");
        }
    }

    private void PatternInstantiate()
    {
        pattern = Instantiate(Resources.Load<GameObject>("Prefabs/PatternBG"));
        pattern.transform.position = new Vector3(0, 10, 0);
    }

    private void NoteUpdate()
    {
        Vector3 downVector = pattern.transform.position;
        downVector.y -= 1;
        pattern.transform.position = Vector3.MoveTowards(pattern.transform.position, downVector, 0.01f);
    }

    private void KeyJudging(String key)
    {
        bool isPerfect = GameObject.Find(key + "PerfectCollider").GetComponent<KeyJudge>().isJudge;
        bool isGood = GameObject.Find(key + "GoodCollider").GetComponent<KeyJudge>().isJudge;
        bool isBad = GameObject.Find(key + "BadCollider").GetComponent<KeyJudge>().isJudge;
        String judgeString = "";
        if (isBad)
        {
            judgeString = "Bad";
        }
        if (isGood)
        {
            judgeString = "Good";
        }
        if (isPerfect)
        {
            judgeString = "Perfect";
        }
        Debug.Log(judgeString);
    }
}
