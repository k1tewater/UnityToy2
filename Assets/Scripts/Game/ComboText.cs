using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ComboText : MonoBehaviour
{
    public int combo{get{return _combo;}}
    int _combo;
    TMP_Text self;
    void Start()
    {
        self = GetComponent<TMP_Text>();
        _combo = 0;
    }
    public void Add()
    {
        _combo++;
        self.text = $"<size=60>{_combo}\n<size=17/>Combo";
    }
    public void Break()
    {
        _combo = 0;
        self.text = $"<size=60>{_combo}\n<size=17/>Combo";
    }
}
