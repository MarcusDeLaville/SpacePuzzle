using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PuzzleInput : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] private CanvasScaler _dragCanvasScaler;
    [SerializeField] private GameObject _basePoint;
    [SerializeField] private FinalCounter _finalCounter;

    private Sounds _sounds;
    private RectTransform _rectTransform;
    private bool _isPlased = false;

    private void Start()
    {
        _sounds = FindObjectOfType<Sounds>();
        _rectTransform = GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!_isPlased)
        {
            transform.localPosition = transform.localPosition + UnscaleEventDeltaPosition(eventData.delta);
            gameObject.GetComponent<StartTranslate>().IsUsed = true;
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (Vector2.Distance(transform.localPosition, _basePoint.transform.localPosition) < 5)
        {

            transform.localPosition = _basePoint.transform.localPosition;
            _isPlased = true;
            _finalCounter.AddPart();
            _sounds.PlayClip(0);
        }
        else
        {
            _sounds.PlayClip(1);
            gameObject.GetComponent<StartTranslate>().IsUsed = false;
        }
    }

    private Vector3 UnscaleEventDeltaPosition(Vector3 point)
    {
        var referenceResolution = _dragCanvasScaler.referenceResolution;
        var currentResolution = new Vector2(Screen.width, Screen.height);

        var widthRatio = currentResolution.x / referenceResolution.x;
        var heightRatio = currentResolution.y / referenceResolution.y;
        var ratio = Mathf.Lerp(widthRatio, heightRatio, _dragCanvasScaler.matchWidthOrHeight);

        return point / ratio;
    }
}
