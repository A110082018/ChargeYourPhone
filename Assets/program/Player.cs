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
        //// ���o��V���J
        // //float H = Input.GetAxis("Horizontal");
        // //float V = Input.GetAxis("Vertical");

        //// ���o�����n���J
        //float h = joyStick.Horizontal;
        //float v = joyStick.Vertical;

        //// �X����V�V�q
        //Vector3 dir = new Vector3(h, 0, v);

        //// �վ㨤�⭱���V
        //// �P�_��V�V�q���׬O�_�j�� 0.1�]�N����J�^
        //if (dir.magnitude > 0.1f)
        //{
        //    // �N��V�V�q�ର����
        //    float faceAngle = Mathf.Atan2(h, v) * Mathf.Rad2Deg;

        //    // �ϥ� Lerp ������V
        //    Quaternion targetRotation = Quaternion.Euler(0, faceAngle, 0);
        //    transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.3f);
        //}



        //controller.velocity = new Vector3(h * speed, controller.velocity.y, v * speed) ;

    }

    private void FixedUpdate()
    {
        // ���o��V���J
        //float H = Input.GetAxis("Horizontal");
        //float V = Input.GetAxis("Vertical");

        // ���o�����n���J
        float h = joyStick.Horizontal;
        float v = joyStick.Vertical;

        // �X����V�V�q
        Vector3 dir = new Vector3(h, 0, v);

        // �վ㨤�⭱���V
        // �P�_��V�V�q���׬O�_�j�� 0.1�]�N����J�^
        if (dir.magnitude > 0.1f)
        {
            // �N��V�V�q�ର����
            float faceAngle = Mathf.Atan2(h, v) * Mathf.Rad2Deg;

            // �ϥ� Lerp ������V
            Quaternion targetRotation = Quaternion.Euler(0, faceAngle, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.3f);
        }



        controller.velocity = new Vector3(h * speed, controller.velocity.y, v * speed);
    }




}

