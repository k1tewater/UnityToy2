using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance;
    public static Managers GetInstance { get { Init(); return s_instance; } }

    ObjectManager _object = new ObjectManager();
    InputManager _input = new InputManager();
    public static InputManager Input { get { return GetInstance._input; } }
    public static ObjectManager Object { get { return GetInstance._object; } }

    void Start()
    {
        Init();
    }

    void Update()
    {
        _input.Update();
    }

    static void Init()
    {
        if (s_instance == null)
        {
            GameObject ob = GameObject.Find("@Managers");
            if (ob == null)
            {
                ob = new GameObject { name = "@Managers" };
                ob.AddComponent<Managers>();
            }

            DontDestroyOnLoad(ob);
            s_instance = ob.GetComponent<Managers>();
        }
    }
}
