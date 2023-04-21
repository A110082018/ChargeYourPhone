using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 5.0f;

    private CharacterController _character;

    private Animator _animator;

    void Start()
    {
        _character = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(x: horizontal, y: 0, z: vertical);

        if (dir != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(dir);

            _animator.SetBool("isRun", true);

            transform.Translate(dir * speed * Time.deltaTime, Space.World);
        }
        else
        {
            _animator.SetBool("isRun", false);
        }


    }
}

