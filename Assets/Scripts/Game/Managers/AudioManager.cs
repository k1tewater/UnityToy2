using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    Define.Tracks _track;
    AudioSource audioSource;
    void Start()
    {
        _track = ObjManager.GetInstance.track;
        audioSource = GetComponent<AudioSource>();

    }

    void Update()
    {

    }
}
