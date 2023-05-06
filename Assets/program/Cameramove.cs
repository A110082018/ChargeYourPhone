using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramove : MonoBehaviour
{

    public Transform player; // 玩家的 Transform 组件
    public float rotateSpeed = 5f; // 摄像机旋转速度

    private Vector3 offset; // 摄像机位置偏移量

    void Start()
    {
        
        // 计算摄像机位置偏移量
        offset = transform.position - player.position;
    }

  
    void LateUpdate()
    {
        // 获取鼠标的水平输入
        float horizontalInput = Input.GetAxis("Mouse X");

        // 计算摄像机绕着玩家的旋转角度
        float angle = horizontalInput * rotateSpeed;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.up);

        // 应用旋转
        offset = rotation * offset;
        transform.position = player.position + offset;

        // 使摄像机始终朝向玩家
        transform.LookAt(player);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left mouse button clicked");

        }
    }


}
