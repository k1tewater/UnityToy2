using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    static public AudioSource _audio;
    AudioClip[] _clips;
    void Start()
    {
        _audio = GetComponent<AudioSource>();
        _clips = new AudioClip[]{
            Resources.Load<AudioClip>("Tracks/track01/track01"),
            Resources.Load<AudioClip>("Tracks/track02/track02"),
            Resources.Load<AudioClip>("Tracks/track03/track03")
        };

    }

    void Update()
    {
        _audio.clip = _clips[(int)SelectManager.centerTrack];
    }
}
