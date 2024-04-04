using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class TestScript : MonoBehaviour
{
    int selectedTrackNum;
    bool isSelected;
    GameObject[] tracks;
    void Start()
    {
        selectedTrackNum = 1;
        isSelected = false;

        tracks = new GameObject[] { GameObject.Find("Track01"), GameObject.Find("Track02"), GameObject.Find("Track03") };

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GameObject.Find("Track01").GetComponent<Animation>().Play("TrackDisable");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GameObject.Find("Track01").GetComponent<Animation>().Play("TrackEnable");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GameObject.Find("Track01").GetComponent<Animation>().Play("TrackSelected");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameObject.Find("Track01").GetComponent<Animation>().Play("TrackDeselected");
        }
    }

    void SelectTrack()
    {

    }

    void ChangeTrack(bool isRight)
    {

    }

    void DisableTrack(int trackNum)
    {
        tracks[trackNum - 1].GetComponent<Animation>().Play("TrackDisable");
    }
}
