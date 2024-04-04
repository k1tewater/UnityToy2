using System;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Dictionary<KeyCode, string> keyAnimationMap = new Dictionary<KeyCode, string>
    {
        {KeyCode.D, ""}, {KeyCode.F, ""}, {KeyCode.J, ""}, {KeyCode.K, ""}
    };
    Dictionary<KeyCode, int> keyIndexMap = new Dictionary<KeyCode, int>
    {
        {KeyCode.D, 0}, {KeyCode.F, 1}, {KeyCode.J, 2}, {KeyCode.K, 3}
    };
    void Update()
    {
        foreach (var kvp in keyAnimationMap)
        {
            if (Input.GetKeyDown(kvp.Key))
            {
                PlayAnimation(kvp.Key, true);
                int idx;
                keyIndexMap.TryGetValue(kvp.Key, out idx);
                ObjManager.GetInstance.keyEffects[idx].enabled = true;
            }
            if (Input.GetKeyUp(kvp.Key))
            {
                PlayAnimation(kvp.Key, false);
                int idx;
                keyIndexMap.TryGetValue(kvp.Key, out idx);
                ObjManager.GetInstance.keyEffects[idx].enabled = false;
            }
        }
    }

    private void PlayAnimation(KeyCode key, bool isPressed)
    {
        foreach (var keyObj in ObjManager.GetInstance.keys)
        {
            if (keyObj != null && keyObj.CompareTag(key.ToString()))
            {
                keyObj.GetComponent<Animator>().SetBool("isPressed", isPressed);
            }
        }
    }
}
