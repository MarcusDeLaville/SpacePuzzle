using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleElement : MonoBehaviour
{
    private bool _isPlased = false;

    public bool IsPlased
    {
        get
        {
            return _isPlased;
        }
        set
        {
            _isPlased = value;
        }
    }
}
