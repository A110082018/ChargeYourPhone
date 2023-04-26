using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramove : MonoBehaviour
{
    public Transform target; //���H�ؼХD��
    public float x;
    public float y;
    public float xSpeed = 1;//x�F�ӫ�
    public float ySpeed = 1;//y�F�ӫ�
    public float Distance;//��e��v���P�D�����Z��
    public float DisSpeed = 1;//�u������D���Z�����F�ӫ�
    public float minDistance = 1;//��v���P�D�����̤p�Z��
    public float maxDistance = 5;//��v���P�D�����̤j�Z��

    private Quaternion rotationEuler;
    private Vector3 cameraPosition;

    private void LateUpdate()
    {

        //Ū���ƹ���x y����
        x += Input.GetAxis("Mouse X") * xSpeed * Time.deltaTime;
        y -= Input.GetAxis("Mouse Y") * ySpeed * Time.deltaTime;


        //�O��x�]�w�b360�ץH��
        if (x > 360)
        {
            x -= 360;
        }
        else if (x<0)
        {
            x += 360;
        }

        //Ū���ƹ��u�����ƭ�
        Distance -= Input.GetAxis("Mouse ScrollWheel") * DisSpeed * Time.deltaTime;
        //����Z��
        Distance = Mathf.Clamp(Distance, minDistance, maxDistance);

        //�B����v���y�СB����
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
