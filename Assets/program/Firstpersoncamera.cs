using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firstpersoncamera : MonoBehaviour
{

    public static bool infirstpersonmode = false;
    public float mouseSensitivity = 100f;

    public Transform playerBody;

    float xRotation = 0f;

   
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
       
    }

    // Update is called once per frame
    void Update()
    {
        //旋轉身體的視角
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // 讓頭部旋轉在90度

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

        if(infirstpersonmode == true)
        {
            move.ismove = false;
        }

        else if(infirstpersonmode == false)
        {
            move.ismove = true;
        }
    }
}
