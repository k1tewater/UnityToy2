using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Track : MonoBehaviour
{
    public int trackNum;
    Image img;
    TMP_Text title;
    TMP_Text diff;
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponentsInChildren<Image>()[2];
        var texts = GetComponentsInChildren<TMP_Text>();
        title = texts[0];
        diff = texts[1];
    }
    
    public void SetTitle(string title, string producer, int bpm)
    {
        string text = $"{title}\n<size=15>Prod. {producer}\nBPM - {bpm}";
        this.title.text = text;
    }

    public void SetDiff(int easy, int normal=-1, int hard=-1)
    {
        string text = $"  <color=\"blue\">Easy - {easy}\n  ";
        if (normal!=-1)
            text += $"<color=\"yellow\">Normal - {normal}\n  ";
        if (hard!=-1)
            text += $"<color=\"red\">Hard - {hard}</color>";

        diff.text = text;
    }
}
