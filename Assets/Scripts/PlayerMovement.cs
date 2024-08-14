using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] CharacterController _characterC;
    [SerializeField] float _speed = 4.5f;
    float _smoothTurnTime = 0.1f;
    float _smoothVelocity;

    [Header("Camera")]
    [SerializeField] Transform _camera;


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical);

        if (Input.GetKeyDown(KeyCode.LeftShift)) //lame kind of sprint and works just fine
        {
            _speed = _speed + 2;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            _speed = _speed - 2;
        }

        if (direction.magnitude >= 0.1f) 
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + _camera.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref _smoothVelocity, _smoothTurnTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            _characterC.Move(moveDirection.normalized * _speed * Time.deltaTime);
        }
    }

    
}
