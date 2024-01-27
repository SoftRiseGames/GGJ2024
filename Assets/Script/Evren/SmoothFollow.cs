using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    public Transform target;        // The target to follow
    public float smoothSpeed = 5f;  // The speed of smooth interpolation

    void Update()
    {
        if (target != null)
        {
            Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
        }
    }
}
