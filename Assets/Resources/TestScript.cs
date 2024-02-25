using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GameObject.Find("Track01").GetComponent<Animation>().Play("TrackDisable");
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            GameObject.Find("Track01").GetComponent<Animation>().Play("TrackEnable");
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            GameObject.Find("Track01").GetComponent<Animation>().Play("TrackSelected");
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            GameObject.Find("Track01").GetComponent<Animation>().Play("TrackDeselected");
        }
    }
}
