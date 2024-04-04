using System;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Dictionary<KeyCode, string> keyAnimationMap = new Dictionary<KeyCode, string>
    {
        {KeyCode.D, ""}, {KeyCode.F, ""}, {KeyCode.J, ""}, {KeyCode.K, ""}
    };
    void Update()
    {
        foreach (var kvp in keyAnimationMap)
        {
            if(Input.GetKeyDown(kvp.Key))
            {
                PlayAnimation(kvp.Key, true);
            }
            if(Input.GetKeyUp(kvp.Key))
            {
                PlayAnimation(kvp.Key, false);
            }
        }
    }

    private void PlayAnimation(KeyCode key, bool isPressed)
    {
        foreach(var keyObj in ObjManager.GetInstance.keys)
        {
            if(keyObj != null && keyObj.CompareTag(key.ToString()))
            {
                keyObj.GetComponent<Animator>().SetBool("isPressed", isPressed);
            }
        }
    }
}
