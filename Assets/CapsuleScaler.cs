using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _targetScale;
    
    void Start()
    {
        _targetScale = new Vector3(4, 4, 4);
    }

    void Update()
    {
        Scale();
    }

    private void Scale()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale,
            _targetScale, _speed * Time.deltaTime);
    }
}