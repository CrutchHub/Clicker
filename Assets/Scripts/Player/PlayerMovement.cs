using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController controller;

    [SerializeField] private float moveSpeed = 10;
    [SerializeField] private float gravityForce = -3f;

    private Vector3 _velocity;

    private Vector2 _keyboardInput;

    private void Update()
    {
        //_keyboardInput.x = Input.GetAxis("Horizontal");
        //_keyboardInput.y = Input.GetAxis("Vertical");

        _velocity = transform.forward * _keyboardInput.y  +  transform.right * _keyboardInput.x;
        _velocity = Vector3.ClampMagnitude(_velocity, 1);
        _velocity.y = gravityForce;
        _velocity *= moveSpeed * Time.deltaTime;

        controller.Move(_velocity);
    }

    private void OnMove(InputValue value)
    {
        _keyboardInput = value.Get<Vector2>();
    }
}
