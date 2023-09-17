using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectorView : MonoBehaviour
{
    private RectTransform _rectTransform;
    [SerializeField] private float _speed = 25f;

    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        var selected = EventSystem.current.currentSelectedGameObject;

        if (selected == null) return;

        transform.position = Vector3.Lerp(_rectTransform.position, selected.transform.position, _speed * Time.deltaTime);

        var otherRect = selected.GetComponent<RectTransform>();

        var horizontalLerp = Mathf.Lerp(_rectTransform.rect.size.x, otherRect.rect.size.x, _speed * Time.deltaTime);
        var verticalLerp = Mathf.Lerp(_rectTransform.rect.size.y, otherRect.rect.size.y, _speed * Time.deltaTime);

        _rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, horizontalLerp);
        _rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, verticalLerp); ;
    }


}
