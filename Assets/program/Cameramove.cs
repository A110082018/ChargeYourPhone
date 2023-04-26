using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramove : MonoBehaviour
{
    public Transform target; //跟隨目標主角
    public float x;
    public float y;
    public float xSpeed = 1;//x靈敏度
    public float ySpeed = 1;//y靈敏度
    public float Distance;//當前攝影機與主角的距離
    public float DisSpeed = 1;//滾輪控制主角距離的靈敏度
    public float minDistance = 1;//攝影機與主角的最小距離
    public float maxDistance = 5;//攝影機與主角的最大距離

    private Quaternion rotationEuler;
    private Vector3 cameraPosition;

    private void LateUpdate()
    {

        //讀取滑鼠的x y移動
        x += Input.GetAxis("Mouse X") * xSpeed * Time.deltaTime;
        y -= Input.GetAxis("Mouse Y") * ySpeed * Time.deltaTime;


        //保證x設定在360度以內
        if (x > 360)
        {
            x -= 360;
        }
        else if (x<0)
        {
            x += 360;
        }

        //讀取滑鼠滾輪的數值
        Distance -= Input.GetAxis("Mouse ScrollWheel") * DisSpeed * Time.deltaTime;
        //限制距離
        Distance = Mathf.Clamp(Distance, minDistance, maxDistance);

        //運算攝影機座標、旋轉
        rotationEuler = Quaternion.Euler(y, x, 0);
        cameraPosition = rotationEuler * new Vector3(0, 0, -Distance) + target.position;


        transform.rotation = rotationEuler;
        transform.position = cameraPosition;
    }

     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
