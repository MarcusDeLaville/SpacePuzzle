using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCounter : MonoBehaviour
{
    [SerializeField] private int _collectedParts;
    [SerializeField] private Animator _animator;
    [SerializeField] private Sounds _sounds;

    private void Start()
    {
        _sounds = FindObjectOfType<Sounds>();
    }

    public void AddPart()
    {
        _collectedParts++;

        if(_collectedParts == 4)
        {
            _sounds.PlayEffect();
            _animator.SetBool("isOpen", true);

        }
    }
}
