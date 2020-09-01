using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSourceTaps;
    [SerializeField] private AudioSource _audioSourceEffects;
    [SerializeField] private AudioClip[] _audioClips;

    public void PlayClip(int index)
    {
        _audioSourceTaps.clip = _audioClips[index];
        _audioSourceTaps.Play();
    }

    public void PlayEffect()
    {
        _audioSourceEffects.clip = _audioClips[2];
        _audioSourceEffects.Play();
    }
}
