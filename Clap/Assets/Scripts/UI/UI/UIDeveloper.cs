using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIDeveloper : UIWindow
{
    public float scrollSpeed = 100f; // �����ٶ�
    public ScrollRect Rect;
    RectTransform rectTransform;
    float t = -50;
    private void Start()
    {
        rectTransform = Rect.GetComponent<RectTransform>();
    }

    private void Update()
    {
        if (!Input.GetMouseButton(0))
        {
            if(t < Rect.content.rect.height - rectTransform.rect.height) t += Time.deltaTime * scrollSpeed;
            if(t>0)Rect.content.anchoredPosition = new Vector2(Rect.content.anchoredPosition.x, t);
        }
        else
        {
            t = Rect.content.anchoredPosition.y;
        }
    }
}