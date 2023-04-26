using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Littlegame2 : MonoBehaviour
{

    private float _rotateSpeed = 10f;
    private Vector3 _startPosition;
    private Vector3 _endPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _startPosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            _endPosition = Input.mousePosition;
            Vector3 difference = _endPosition - _startPosition;
            transform.Rotate(Vector3.forward, -difference.x * _rotateSpeed * Time.deltaTime, Space.Self);
            _startPosition = _endPosition;
        }



    }
}
