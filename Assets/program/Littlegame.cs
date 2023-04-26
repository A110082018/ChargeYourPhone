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
        if (Input.GetKey("d"))//��J.�Ӧ���L(��d��)
        {
            this.gameObject.transform.position += new Vector3(speed, 0, 0);
        }  //�����O.�o�Ӫ���.�y�Шt��.��m(���@�ӦV�q��x,y,z)+=�o�ӦV�q

        //�V����
        if (Input.GetKey("a"))
        {
            this.gameObject.transform.position -= new Vector3(speed, 0, 0);
        }
        //�V�W��
        if (Input.GetKey("w"))
        {
            this.gameObject.transform.position += new Vector3(0, speed, 0);
        }
        //�V�U��
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
