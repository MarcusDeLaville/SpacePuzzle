using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTranslate : MonoBehaviour
{
    [SerializeField] private RectTransform _targetPosition;
    [SerializeField] private float _speed;

    private RectTransform _transform;
    private bool _isUsed;

    private void Start()
    {
        _transform = GetComponent<RectTransform>();
    }
    
    private void Update()
    {
        if (!_isUsed)
        {
        _transform.anchoredPosition = Vector2.MoveTowards(_transform.anchoredPosition, _targetPosition.anchoredPosition, _speed);
        }

        if(_transform.anchoredPosition == _targetPosition.anchoredPosition)
        {
            _isUsed = true;
        }

    }

    public bool IsUsed
    {
        get
        {
            return _isUsed;
        }
        set
        {
            _isUsed = value;
        }
    }
}
