using UnityEngine;

public class jump : MonoBehaviour
{

    public float jumpForce = 10f;
    public Rigidbody rb;
    public int maxJumps = 2;

    private int jumpsRemaining;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpsRemaining = maxJumps;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpsRemaining > 0)
        {
            if (jumpsRemaining == 1) // �p�G�ٳѤU�̫�@�����D���ơA�u�ϥΤ@�b���O�q
            {
                rb.AddForce(Vector3.up * jumpForce * 0.5f, ForceMode.Impulse);
            }
            else
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
            jumpsRemaining--;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            jumpsRemaining = maxJumps;
        }
    }
}