using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    [SerializeField] private float maxDistance = 10f;
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    private void FixedUpdate()
    {
        Vector3 mousePos = Input.mousePosition;
        Ray rayOrigin = cam.ScreenPointToRay(mousePos);
        RaycastHit hitInfo;
        Vector3 point = Vector3.zero;
        if (Physics.Raycast(rayOrigin, out hitInfo, Mathf.Infinity))
        {
            if (hitInfo.collider)
            {
                point = hitInfo.point;
            }
        }
        else
        {
            point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, maxDistance));
        }

        transform.LookAt(point);
    }
}