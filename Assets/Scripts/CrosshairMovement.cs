using UnityEngine;

public class CrosshairMovement : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        transform.position = Input.mousePosition;
    }
}
