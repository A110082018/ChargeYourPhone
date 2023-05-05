using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Littlegame5 : MonoBehaviour
{

    public static int count = 0; // 計數器
    public Transform target; // 目標位置

    private bool isMoving = false; // 是否正在移動
    private Vector3 targetPosition; // 目標位置的世界座標
    private float moveSpeed = 10f; // 移動速度

    private void Update()
    {
        if (isMoving)
        {
            // 將當前位置移動向目標位置
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // 判斷是否到達目標位置
            if (transform.position == targetPosition)
            {
                isMoving = false;
            }
        }
    }

    private void OnMouseDown()
    {
        if (gameObject.tag == "puzzle")
        {
            // 將目標位置轉換為世界座標
            targetPosition = target.position;

            // 開始移動
            isMoving = true;

            // 增加計數器
            count++;
        }
    }



    //private Vector3 startPosition;
    //private Vector3 correctPosition;
    //private bool isDragging = false;

    //void Start()
    //{
    //    // 初始化拼圖位置
    //    startPosition = transform.position;
    //    correctPosition = GameObject.Find(gameObject.name + "p").transform.position;
    //}

    //void Update()
    //{
    //    // 拖動拼圖
    //    if (isDragging)
    //    {
    //        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //        transform.position = new Vector3(mousePosition.x, mousePosition.y, 0);
    //    }
    //}

    //void OnMouseDown()
    //{
    //    isDragging = true;
    //}

    //void OnMouseUp()
    //{
    //    isDragging = false;

    //    // 確認拼圖位置
    //    if (Vector3.Distance(transform.position, correctPosition) < 0.005f)
    //    {
    //        transform.position = correctPosition;
    //    }
    //    else
    //    {
    //        transform.position = startPosition;
    //    }
    //}
}
