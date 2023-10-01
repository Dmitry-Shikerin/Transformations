using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(0.5f * Time.deltaTime * _speed, 0, 0);
    }
}
