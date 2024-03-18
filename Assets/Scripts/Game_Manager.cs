using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    GameObject[] keys = new GameObject[4];
    // Start is called before the first frame update
    void Start()
    {
        keys[0] = GameObject.Find("Key1");
        keys[1] = GameObject.Find("Key2");
        keys[2] = GameObject.Find("Key3");
        keys[3] = GameObject.Find("Key4");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            keys[0].GetComponent<Animation>().Play("KeyPressed");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            keys[1].GetComponent<Animation>().Play("KeyPressed");
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            keys[2].GetComponent<Animation>().Play("KeyPressed");
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            keys[3].GetComponent<Animation>().Play("KeyPressed");
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            keys[0].GetComponent<Animation>().Play("KeyUnpressed");
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            keys[1].GetComponent<Animation>().Play("KeyUnpressed");
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            keys[2].GetComponent<Animation>().Play("KeyUnpressed");
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            keys[3].GetComponent<Animation>().Play("KeyUnpressed");
        }
    }
}
