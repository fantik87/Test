using UnityEngine;
using UnityEngine.EventSystems;

public class JoyStick : MonoBehaviour, IDragHandler, IEndDragHandler
{
    [SerializeField] GameObject JoySt;
    [SerializeField] float MoveRadius;

    static JoyStick instance;


    public Vector2 Position
    {
        get 
        {
            return (instance.JoySt.transform.position - instance.gameObject.transform.position).normalized;
        }

    }


    private void Start()
    {
        instance = this;

    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 inputPosition = Camera.main.ScreenToWorldPoint(eventData.position);

        Vector3 offset = inputPosition - gameObject.transform.position;

        offset = new Vector3(offset.x, offset.y, 0);

        JoySt.gameObject.transform.position = gameObject.transform.position + Vector3.ClampMagnitude(offset, MoveRadius);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        JoySt.transform.localPosition = Vector3.zero;
    }
}
