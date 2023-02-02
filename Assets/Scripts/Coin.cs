using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Coin : MonoBehaviour
{
    [SerializeField]private float _maxSpeed;
    [SerializeField]private float _minSpeed;
    
    private float _speed;
    private Vector3 _rotationVelocity;
    private Transform _player;

    private void Start()
    {
        _player = FindObjectOfType<PlayerMovement>().gameObject.transform;
        _speed = Random.Range(_minSpeed, _maxSpeed);
        _rotationVelocity = Vector3.up * (_speed * Time.deltaTime);
    }

    private void Update()
    {
        transform.Rotate(_rotationVelocity, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.TryGetComponent(out PlayerMovement playerMovement))
        {
            Destroy(gameObject);
        }
    }
}
