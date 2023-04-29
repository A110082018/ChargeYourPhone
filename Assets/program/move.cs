using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody rigidbody;
    private Animator animator;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(horizontal, 0, vertical);
        if (dir.magnitude > 1) dir.Normalize();

        if (dir != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(dir);

            animator.SetBool("isRun", true);

            rigidbody.MovePosition(transform.position + dir * speed * Time.fixedDeltaTime);
        }
        else
        {
            animator.SetBool("isRun", false);
        }
    }
}







