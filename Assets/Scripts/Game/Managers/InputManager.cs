using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
    ObjectManager objManager = Managers.Object;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            objManager.keys[0].GetComponent<Animation>().Play("KeyPressed");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            objManager.keys[1].GetComponent<Animation>().Play("KeyPressed");
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            objManager.keys[2].GetComponent<Animation>().Play("KeyPressed");
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            objManager.keys[3].GetComponent<Animation>().Play("KeyPressed");
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            objManager.keys[0].GetComponent<Animation>().Play("KeyUnpressed");
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            objManager.keys[1].GetComponent<Animation>().Play("KeyUnpressed");
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            objManager.keys[2].GetComponent<Animation>().Play("KeyUnpressed");
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            objManager.keys[3].GetComponent<Animation>().Play("KeyUnpressed");
        }
    }
}
