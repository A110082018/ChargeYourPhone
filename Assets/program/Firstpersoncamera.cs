using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firstpersoncamera : MonoBehaviour
{


    public float lookSpeed = 3.0f; // 鼠标移动速度
    public float moveSpeed = 3.0f; // 相机移动速度

    private float rotationX = 0.0f;
    private float rotationY = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
       
    }

    // Update is called once per frame
    void Update()
    {
        // 获取鼠标移动量
        rotationX += Input.GetAxis("Mouse X") * lookSpeed;
        rotationY += Input.GetAxis("Mouse Y") * lookSpeed;

        // 限制相机的俯仰角度
        rotationY = Mathf.Clamp(rotationY, -90, 90);

        // 根据鼠标移动量旋转相机
        transform.localRotation = Quaternion.AngleAxis(rotationX, Vector3.up);
        transform.localRotation *= Quaternion.AngleAxis(rotationY, Vector3.left);

    }
}
