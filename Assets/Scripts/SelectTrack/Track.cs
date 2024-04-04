using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Track : MonoBehaviour
{
    readonly int IS_SELECTED = Animator.StringToHash("isSelected"),
    IS_CENTER = Animator.StringToHash("isCenter"),
    IS_ELSE_SELECTED = Animator.StringToHash("isElseSelected");
    Animator animator;
    int trackNum;
    Define.Tracks track;
    public bool isSelected = false;
    void Start()
    {
        animator = GetComponent<Animator>();

        int numStartidx = name.IndexOf("Track") + 5;
        trackNum = int.Parse(name[numStartidx..]);
        track = (Define.Tracks)(trackNum - 1);
    }

    void Update()
    {
        if (SelectManager.centerTrack == track)
        {
            animator.SetBool(IS_CENTER, true);
            if (isSelected)
            {
                animator.SetBool(IS_SELECTED, true);
            }
            else
            {
                animator.SetBool(IS_SELECTED, false);
            }
        }
        else
        {
            animator.SetBool(IS_CENTER, false);
        }
    }

}
