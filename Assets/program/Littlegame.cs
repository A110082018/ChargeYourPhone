using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Littlegame : MonoBehaviour
{
    public float speed;

    private Vector3 origin;

    // Start is called before the first frame update
    void Start()
    {
        origin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))//輸入.來自鍵盤(“d”)
        {
            this.gameObject.transform.position += new Vector3(speed, 0, 0);
        }  //此類別.這個物件.座標系統.位置(為一個向量值x,y,z)+=這個向量

        //向左走
        if (Input.GetKey("a"))
        {
            this.gameObject.transform.position -= new Vector3(speed, 0, 0);
        }
        //向上走
        if (Input.GetKey("w"))
        {
            this.gameObject.transform.position += new Vector3(0, speed, 0);
        }
        //向下走
        if (Input.GetKey("s"))
        {
            this.gameObject.transform.position -= new Vector3(0, speed, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
      
      transform.position = origin;
      
        
    }
    
}
