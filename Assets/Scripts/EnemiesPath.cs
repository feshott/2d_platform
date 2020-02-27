using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesPath : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform[] _points;
    private int _currentPoint = 0;
    private SpriteRenderer spriteR;

    void Start()
    {
        spriteR = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        Transform target = _points[_currentPoint];
        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);
        if (transform.position == target.position)
        {
            _currentPoint = _currentPoint == 0 ? 1 : 0;
            spriteR.flipX = _currentPoint == 0 ? false : true;
        }
    }
}
