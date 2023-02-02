using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _speedRotation;

    private Vector3 _inputDirection;
    private Vector3 _inputRotationY;
    private Vector3 _moveVelocity;
    private Vector3 _rotationVelocity;
    private Rigidbody _rigidbody;
    
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _inputDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        _inputRotationY = new Vector3(0f, Input.GetAxisRaw("Mouse X"), 0f);
        _moveVelocity = _inputDirection.normalized * (_speed * Time.deltaTime);
        _rotationVelocity = _inputRotationY * (_speedRotation * Time.deltaTime);
        
        transform.Translate(_moveVelocity);
        transform.Rotate(_rotationVelocity);
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
    
}
