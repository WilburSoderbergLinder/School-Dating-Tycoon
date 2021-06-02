using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [Range (0, 1)]
    public float speed;
    [Range(0, 1)]
    public float smoothSpeed;
    Vector3 desiredPosition;
    private void FixedUpdate()
    {
        desiredPosition += new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0);

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

    }
}
