using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour
{
    private float baseAngle = 0.0f;

    void OnMouseDown()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        pos = Input.mousePosition - pos;
        baseAngle = Mathf.Atan2(pos.x, pos.x) * Mathf.Rad2Deg;
        baseAngle -= Mathf.Atan2(transform.right.z, transform.right.z) * Mathf.Rad2Deg;
    }

    void OnMouseDrag()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        pos = Input.mousePosition - pos;
        float ang = Mathf.Atan2(pos.z, pos.x) * Mathf.Rad2Deg - baseAngle;
        transform.rotation = Quaternion.AngleAxis(ang, Vector3.forward);
    }
}