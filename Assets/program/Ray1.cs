using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ray1 : MonoBehaviour
{
    public GameObject littlegameplay;
    public GameObject littlecamera;
    public GameObject littlegameplay2;
    public GameObject littlecamera2;
    public GameObject littlegameplay3;
    public GameObject littlecamera3;
    public GameObject littlegameplay4;
    public GameObject littlecamera4;
    public GameObject littlegameplay5;
    public GameObject littlecamera5;

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.name == "gametrigger")
            {
                Playercontroller1.littlegameplayON = true;
                littlegameplay.SetActive(true);
                littlecamera.SetActive(true);
                
                Debug.Log(hit.transform.name);
                Debug.DrawLine(Camera.main.transform.position, hit.transform.position, Color.red, 0.5f, true);
            }
            else if (hit.collider.gameObject.name == "gametrigger2")
            {
                Playercontroller1.littlegameplayON = true;
                littlegameplay2.SetActive(true);
                littlecamera2.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Debug.Log(hit.transform.name);
                Debug.DrawLine(Camera.main.transform.position, hit.transform.position, Color.red, 0.5f, true);
            }
            else if (hit.collider.gameObject.name == "gametrigger3")
            {
                Playercontroller1.littlegameplayON = true;
                littlegameplay3.SetActive(true);
                littlecamera3.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Debug.Log(hit.transform.name);
                Debug.DrawLine(Camera.main.transform.position, hit.transform.position, Color.red, 0.5f, true);
            }
            else if (hit.collider.gameObject.name == "trigger")
            {
                Playercontroller1.littlegameplayON = true;
                littlegameplay5.SetActive(true);
                littlecamera5.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Debug.Log(hit.transform.name);
                Debug.DrawLine(Camera.main.transform.position, hit.transform.position, Color.red, 0.5f, true);
            }
        }
    }

    //float MaxDistance = 100;

    //public Controller controller;
    ////public  GameObject littlegameplay;
    ////public  GameObject littlecamera;
    ////public GameObject littlegameplay2;
    ////public GameObject littlecamera2;
    ////public GameObject littlegameplay3;
    ////public GameObject littlecamera3;
    ////public GameObject littlegameplay4;
    ////public GameObject littlecamera4;
    ////public GameObject littlegameplay5;
    ////public GameObject littlecamera5;



    //private void Start()
    //{

    //}


    //// Update is called once per frame
    //void Update()
    //{
    //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

    //    //螢幕射線

    //    RaycastHit hit;

    //    if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hit)&& hit.collider.gameObject.name == "Bed_Doll")
    //    {
    //        controller.SetGameTriggered(true);
    //        //Playercontroller1.littlegameplayON = true;
    //        //littlegameplay.SetActive(true);
    //        //littlecamera.SetActive(true);
    //        Debug.Log(hit.transform.name);
    //        Debug.DrawLine(Camera.main.transform.position, hit.transform.position, Color.red, 0.5f, true);                  
    //    }


    //    if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hit,MaxDistance) && hit.collider.gameObject.name == "gametrigger2")
    //    {
    //        controller.SetGameTriggered(true);
    //        //Playercontroller1.littlegameplayON = true;
    //        //littlegameplay2.SetActive(true);
    //        //littlecamera2.SetActive(true);
    //        Cursor.lockState = CursorLockMode.None; // 释放鼠标
    //        Cursor.visible = true; // 显示鼠标光标
    //        //Debug.Log(hit.transform.name);
    //        //Debug.DrawLine(Camera.main.transform.position, hit.transform.position, Color.red, 0.5f, true);

    //    }
    //    if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hit) && hit.collider.gameObject.name == "gametrigger3")
    //    {
    //        controller.SetGameTriggered(true);
    //        //Playercontroller1.littlegameplayON = true;
    //        //littlegameplay3.SetActive(true);
    //        //littlecamera3.SetActive(true);
    //        Cursor.lockState = CursorLockMode.None; // 释放鼠标
    //        Cursor.visible = true; // 显示鼠标光标
    //        //Debug.Log(hit.transform.name);
    //        //Debug.DrawLine(Camera.main.transform.position, hit.transform.position, Color.red, 0.5f, true);

    //    }

    //    if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hit) && hit.collider.gameObject.name == "item4")
    //    {
    //        controller.SetGameTriggered(true);
    //        //Playercontroller1.littlegameplayON = true;
    //        //littlegameplay4.SetActive(true);
    //        //littlecamera4.SetActive(true);
    //        //Debug.Log(hit.transform.name);
    //        //Debug.DrawLine(Camera.main.transform.position, hit.transform.position, Color.red, 0.5f, true);

    //    }



}


