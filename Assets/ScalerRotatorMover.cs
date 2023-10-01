using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalerRotatorMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _scaleSpeed;
    
    private Vector3 _targetScale;
    
    void Start()
    {
        _targetScale = new Vector3(4, 4, 4);
    }

    void Update()
    {
        Move();
        Rotate();
        Scale();
    }
    
    private void Scale()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale,
            _targetScale, _scaleSpeed * Time.deltaTime);
    }
    
    private void Rotate()
    {
        transform.Rotate(0, 0.5f * Time.deltaTime * _rotationSpeed, 0);
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _moveSpeed);
    }
}
