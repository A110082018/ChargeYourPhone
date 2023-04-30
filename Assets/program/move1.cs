using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class move1 : MonoBehaviour
{
    private Rigidbody m_Rigidbody;
    float m_MoveAxis, m_TurnAxis;
    public float moveSpeed, turnSpeed;
    void Start()
    {
        m_MoveAxis = m_TurnAxis = 0;
        moveSpeed = 12; turnSpeed = 180;
        m_Rigidbody = gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        m_MoveAxis = Input.GetAxis("Vertical");     /*检测垂直方向键*/
        m_TurnAxis = Input.GetAxis("Horizontal");   /*检测水平方向键*/
    }
    void FixedUpdate()
    {
        Move();
        Turn();
    }
    /// <summary>
    /// 向前或向后移动
    /// </summary>
    void Move()
    {
        Vector3 moveChange = transform.forward * m_MoveAxis * Time.deltaTime * moveSpeed;    /*移动增量，实际移动向量 = 以自身坐标系为方向的单位方向*键盘输入*两帧间隔*单位移动速度*/
        m_Rigidbody.MovePosition(transform.position + moveChange);
    }
    /// <summary>
    /// 旋转自身
    /// </summary>
    void Turn()
    {
        float Change = m_TurnAxis * Time.deltaTime * turnSpeed;     /*速度增量，方法同上*/
        Quaternion turnChange = Quaternion.Euler(0.0f, Change, 0.0f);
        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * turnChange);
    }
}