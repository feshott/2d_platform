using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;

    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidbody;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            setDirection(false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            setDirection(true);
        }

        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            _animator.ResetTrigger("isRun");
        }

        if (Input.GetKey(KeyCode.Space) && _rigidbody.velocity.y == 0)
        {
            _rigidbody.velocity = new Vector3(0, 7, 0);
        }
    }

    private void setDirection(bool direction)
    {
        var _speedDirection = direction ? -1 : 1;

        transform.Translate(_speed * Time.deltaTime * _speedDirection, 0, 0);
        _spriteRenderer.flipX = direction;
        _animator.SetTrigger("isRun");
    }
}
