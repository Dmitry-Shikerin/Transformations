using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
    }
}
