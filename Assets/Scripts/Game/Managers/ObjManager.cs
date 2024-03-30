using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SceneTemplate;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SocialPlatforms.Impl;

public class ObjManager : MonoBehaviour
{
    static ObjManager instance;
    public static ObjManager GetInstance {get { Init(); return instance;}}

    public GameObject[] keys;
    public ComboText comboText;
    public ScoreText scoreText;
    public JudgeText judgeText;

    void Start()
    {
        Init();
        keys = new GameObject[4]{
        GameObject.Find("Key1"),
        GameObject.Find("Key2"),
        GameObject.Find("Key3"),
        GameObject.Find("Key4")};
        comboText = GameObject.Find("Combo").GetComponent<ComboText>();
        scoreText = GameObject.Find("Score").GetComponent<ScoreText>();
        judgeText = GameObject.Find("Judge").GetComponent<JudgeText>();
    }
    static void Init()
    {
        if(instance == null)
        {
            GameObject ob = GameObject.Find("@ObjManager");
            if(ob == null)
            {
                ob = new GameObject { name = "@ObjManager"};
                ob.AddComponent<ObjManager>();
            }
            DontDestroyOnLoad(ob);
            instance = ob.GetComponent<ObjManager>();
        }        
    }
}
