using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class SelectManager : MonoBehaviour
{
    static public Define.Tracks centerTrack;
    RectTransform[] trackRect;
    GameObject tracks;
    Vector3 vel = Vector3.zero;
    Vector3 target;
    void Start()
    {
        centerTrack = Define.Tracks.Nightmare;
        trackRect = new RectTransform[]{
            GameObject.Find("Track01").GetComponent<RectTransform>(),
            GameObject.Find("Track02").GetComponent<RectTransform>(),
            GameObject.Find("Track03").GetComponent<RectTransform>()
        };
        tracks = GameObject.Find("Tracks");
        target = tracks.transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && !GetSelected() && (int)centerTrack > 0)
        {
            centerTrack -= 1;
            target += Vector3.right * 300f;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && !GetSelected() && (int)centerTrack < Enum.GetValues(typeof(Define.Tracks)).Length - 1)
        {
            centerTrack += 1;
            target += Vector3.right * -300f;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!GetSelected())
            {
                SetSelected(true);
                AudioController._audio.Play();
            }
            else
            {
                PlayerPrefs.SetInt("track", (int)centerTrack);
                SceneManager.LoadScene("Game");
            }

        }

        if (Input.GetKeyDown(KeyCode.Escape) && GetSelected())
        {
            SetSelected(false);
            AudioController._audio.Stop();
        }

        tracks.transform.position = Vector3.SmoothDamp(tracks.transform.position, target, ref vel, 0.3f);
    }

    bool GetSelected()
    {
        return trackRect[(int)centerTrack].gameObject.GetComponent<Track>().isSelected;
    }
    void SetSelected(bool mIsSelected)
    {
        trackRect[(int)centerTrack].gameObject.GetComponent<Track>().isSelected = mIsSelected;
    }
}
