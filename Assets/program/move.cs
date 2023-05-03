using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public static bool ismove = true;
    public float speed = 5.0f;
    private Rigidbody rigidbody;
    private Animator animator;
    private Transform mainCameraTransform;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        mainCameraTransform = Camera.main.transform;
    }

    void FixedUpdate()
    {
       if (ismove == true)
       {
            Move();
       }
      
      
    }
    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 dir = Vector3.zero;

        if (vertical > 0)
        {
            dir = mainCameraTransform.forward;
        }
        else if (vertical < 0)
        {
            dir = -mainCameraTransform.forward;
        }
        else if (horizontal > 0)
        {
            dir = mainCameraTransform.right;
        }
        else if (horizontal < 0)
        {
            dir = -mainCameraTransform.right;
        }

        if (dir != Vector3.zero)
        {
            if (Vector3.Dot(dir, transform.forward) > 0)
            {
                animator.SetBool("isRun", true);
                rigidbody.MovePosition(transform.position + dir.normalized * speed * Time.fixedDeltaTime);
            }
            transform.rotation = Quaternion.LookRotation(new Vector3(dir.x, 0, dir.z));
        }
        else
        {
            animator.SetBool("isRun", false);
        }
    }
}