using UnityEngine;
namespace Doodle.core
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _jumpPower;
        [SerializeField] Rigidbody2D _player;
        [SerializeField] float _movementSpeed;
        [SerializeField] float _distanceForCast;
        [SerializeField] LayerMask _groundMask;
        private static bool _isGrounded;

      
        private void Update()
        {
            if (InputController.IsJumped && _isGrounded)
            {
                Jump();
            }

            else if (!_isGrounded)
            {
                Move();
            }


        }
    private void FixedUpdate()
    {
            _isGrounded = Physics2D.Raycast(_player.position, Vector2.down, _distanceForCast, _groundMask);
            Debug.DrawLine(_player.position, _player.position + Vector2.down * _distanceForCast, Color.red);
        }
        private void Jump()
        {
                _player.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);

        }
        private void Move()
        {
            _player.velocity =new Vector2(InputController.Direction * _movementSpeed, _player.velocity.y);
        }

    }
}