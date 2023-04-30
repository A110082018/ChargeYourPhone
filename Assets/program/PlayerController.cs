using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 5f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Mouse X") * rotationSpeed;
        float verticalInput = Input.GetAxis("Mouse Y") * rotationSpeed;

        transform.RotateAround(transform.position, Vector3.up, -horizontalInput);
        transform.RotateAround(transform.position, transform.right, verticalInput);
    }
}
