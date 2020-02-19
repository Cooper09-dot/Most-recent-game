using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smooothSpeed = 0125f;

    void LateUpdate()
    {
        transform.position = target.position;
    }
}
