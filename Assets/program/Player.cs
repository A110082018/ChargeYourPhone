using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 100f;
    public Joystick joyStick;
    public float MaxHP = 100;
    public float HP = 100;
    private Rigidbody controller;

    void Start()
    {
        controller = GetComponent<Rigidbody>();

    }

    void Update()
    {
        //// 取得方向鍵輸入
        // //float H = Input.GetAxis("Horizontal");
        // //float V = Input.GetAxis("Vertical");

        //// 取得虛擬搖桿輸入
        //float h = joyStick.Horizontal;
        //float v = joyStick.Vertical;

        //// 合成方向向量
        //Vector3 dir = new Vector3(h, 0, v);

        //// 調整角色面對方向
        //// 判斷方向向量長度是否大於 0.1（代表有輸入）
        //if (dir.magnitude > 0.1f)
        //{
        //    // 將方向向量轉為角度
        //    float faceAngle = Mathf.Atan2(h, v) * Mathf.Rad2Deg;

        //    // 使用 Lerp 漸漸轉向
        //    Quaternion targetRotation = Quaternion.Euler(0, faceAngle, 0);
        //    transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.3f);
        //}



        //controller.velocity = new Vector3(h * speed, controller.velocity.y, v * speed) ;

    }

    private void FixedUpdate()
    {
        // 取得方向鍵輸入
        //float H = Input.GetAxis("Horizontal");
        //float V = Input.GetAxis("Vertical");

        // 取得虛擬搖桿輸入
        float h = joyStick.Horizontal;
        float v = joyStick.Vertical;

        // 合成方向向量
        Vector3 dir = new Vector3(h, 0, v);

        // 調整角色面對方向
        // 判斷方向向量長度是否大於 0.1（代表有輸入）
        if (dir.magnitude > 0.1f)
        {
            // 將方向向量轉為角度
            float faceAngle = Mathf.Atan2(h, v) * Mathf.Rad2Deg;

            // 使用 Lerp 漸漸轉向
            Quaternion targetRotation = Quaternion.Euler(0, faceAngle, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.3f);
        }



        controller.velocity = new Vector3(h * speed, controller.velocity.y, v * speed);
    }




}

