using UnityEngine;
using UnityEngine.EventSystems; // 引入事件系统命名空间
using TMPro;

public class HoverExample : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI textComponent;

    public void OnPointerEnter(PointerEventData eventData)
{
    //Debug.Log($"OnPointerEnter - textComponent is null: {textComponent == null}");
    if (textComponent != null)
    {
        textComponent.color = new Color(139f / 255f, 0f / 255f, 18f / 255f); // 北大红
    }
}

public void OnPointerExit(PointerEventData eventData)
{
    //Debug.Log($"OnPointerExit - textComponent is null: {textComponent == null}");
    if (textComponent != null)
    {
        textComponent.color = new Color(102f / 255f, 8f / 255f, 116f / 255f);
    }
}
}