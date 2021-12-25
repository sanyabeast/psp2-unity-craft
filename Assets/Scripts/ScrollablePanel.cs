using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollablePanel : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    RectTransform rectTransform;
    public float scrollableAreaHeight = 540;
    public float scrollingSpeed = 10f;

	// Use this for initialization
    void OnEnable()
    {
        rectTransform = GetComponent<RectTransform>();
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        SetScrollingOffset(rectTransform.position.y - Input.GetAxis("VerticalTurn") * scrollingSpeed);
	}

    public void OnDrag(PointerEventData data)
    {
        SetScrollingOffset(rectTransform.position.y + data.delta.y);
    }

    void SetScrollingOffset(float newY)
    {
        if (newY > rectTransform.sizeDelta.y)
        {
            newY = rectTransform.sizeDelta.y;
        }

        if (newY < scrollableAreaHeight)
        {
            newY = scrollableAreaHeight;
        }

        rectTransform.position = new Vector3(
            rectTransform.position.x,
            newY,
            rectTransform.position.z
        );
    }

    public void OnEndDrag(PointerEventData eventData)
    {
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
    }

}
