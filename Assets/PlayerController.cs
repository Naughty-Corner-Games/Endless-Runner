using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float playerSpeed = 2f, jumpHeight = 5f, horizontalSpeed = 3f;
    [SerializeField] private Transform groundCheck;
    public LayerMask ground;
    public Animator anim;
    public Rigidbody rb;

    public float rightLimit = 5.5f, leftLimit = -5.5f;

    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * playerSpeed, Space.World);
        if (Input.GetKey(KeyCode.A))
        {
            if (this.gameObject.transform.position.x > leftLimit)
            {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (this.gameObject.transform.position.x < rightLimit)
            {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed * -1);
            }
        }

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
            transform.Translate(Vector3.up * Time.deltaTime * jumpHeight);
        }
    }
}
