using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    private SpriteRenderer spriteR;
    private Rigidbody2D rb;
    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
        spriteR = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
            spriteR.flipX = false;
            _animator.SetTrigger("isRun");
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
            spriteR.flipX = true;
            _animator.SetTrigger("isRun");
        }

        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            _animator.ResetTrigger("isRun");
        }

        if (Input.GetKey(KeyCode.Space) && rb.velocity.y == 0)
        {
            rb.velocity = new Vector3(0, 7, 0);
        }
    }
}
