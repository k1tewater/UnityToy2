using UnityEngine;

public class ObjManager : MonoBehaviour
{
    static ObjManager instance;
    public static ObjManager GetInstance { get { Init(); return instance; } }

    public GameObject[] keys;
    public SpriteRenderer[] keyEffects;
    public GameObject pattern;
    public ComboText comboText;
    public ScoreText scoreText;
    public JudgeText judgeText;
    public Define.Tracks track;
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
        pattern = Instantiate(Resources.Load<GameObject>("Prefabs/Pattern"));
        keyEffects = new SpriteRenderer[4]{
            GameObject.Find("Key1Effect").GetComponent<SpriteRenderer>(),
            GameObject.Find("Key2Effect").GetComponent<SpriteRenderer>(),
            GameObject.Find("Key3Effect").GetComponent<SpriteRenderer>(),
            GameObject.Find("Key4Effect").GetComponent<SpriteRenderer>()
        };
        track = (Define.Tracks)PlayerPrefs.GetInt("track");
        Debug.Log(track);
    }
    static void Init()
    {
        if (instance == null)
        {
            GameObject ob = GameObject.Find("@ObjManager");
            if (ob == null)
            {
                ob = new GameObject { name = "@ObjManager" };
                ob.AddComponent<ObjManager>();
            }
            DontDestroyOnLoad(ob);
            instance = ob.GetComponent<ObjManager>();
        }
    }
}
