using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject pattern;

    float _speed;

    // Start is called before the first frame update
    void Start()
    {
        _speed = 5f;

        
        
        PatternInstantiate();
    }

    // Update is called once per frame
    void Update()
    {
        NoteUpdate();
    }

    

    private void PatternInstantiate()
    {
        pattern = Instantiate(Resources.Load<GameObject>("Prefabs/Pattern"));
    }

    private void NoteUpdate()
    {
        Vector3 downVector = pattern.transform.position;
        downVector.y -= 1;
        pattern.transform.position = Vector3.MoveTowards(pattern.transform.position, downVector, _speed * Time.deltaTime);
    }
}
