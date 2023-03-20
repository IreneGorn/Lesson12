using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChangeButtonScale : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 _originalScale;
    private Ease _ease = Ease.InOutSine;
    private float _duration;

    private TweenerCore<Vector3, Vector3, VectorOptions> tweener;
    private Vector3 _scaleTo;
    [SerializeField] private float _scaleButton = 2.0f;

    private void Start()
    {
        _originalScale = transform.localScale;
        _scaleTo = _originalScale * _scaleButton;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tweener = transform.DOScale(_scaleTo, _duration).SetEase(_ease);
        //transform.localScale = new Vector3(1.1f, 1.1f, 1f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tweener = transform.DOScale(_originalScale, _duration).SetEase(_ease);
        //transform.localScale = new Vector3(1f, 1f, 1f);
    }

    [ContextMenu("Stop animation")]
    public void Stop()
    {
        tweener.Pause();
    }
    
    [ContextMenu("Stop animation")]
    public void Play()
    {
        tweener.Play();
    }
}
