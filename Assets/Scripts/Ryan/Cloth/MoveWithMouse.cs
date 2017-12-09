using UnityEngine;

public class MoveWithMouse : MonoBehaviour
{
    float distance = 7;

    public void OnMouseDrag()
    {
        Vector3 screenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z);

        Vector3 offset = Camera.main.ScreenToWorldPoint(screenPoint);

        transform.position = offset;
    }

}
