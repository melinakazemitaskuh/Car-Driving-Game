using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveCar : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _frontTireRB;

    [SerializeField] private Rigidbody2D _backTireRB;

    [SerializeField] private float _speed = 150f;

    [SerializeField] private Rigidbody2D _carRB;

    [SerializeField] private float _rotationspeed = 300f;

    [SerializeField] private AudioSource _hornSound;
    private float _moveInput;


    private void Update()
    {
        _moveInput = Input.GetAxisRaw("Horizontal"); // Corrected from is GetAxis(chat gpt)

        if (_moveInput == 0 && Input.touchCount > 0)
        {//to make sure we are using touchpad and not keyboard
            Touch touch = Input.GetTouch(0);

            if (touch.position.x < Screen.width / 2)
            {//if touch is on the left side of the screen
                _moveInput = -1;
            }
            else
            {
                _moveInput = 1;
            }
        }

        if (Input.GetKeyDown(KeyCode.H))
        {//if H was pressed on keyboard
            _hornSound.Play();//play the sound given
        }
    }

    private void FixedUpdate()
    {
        _frontTireRB.AddTorque(-_moveInput * _speed * Time.fixedDeltaTime);
        _backTireRB.AddTorque(-_moveInput * _speed * Time.fixedDeltaTime);
        _carRB.AddTorque(-_moveInput * _rotationspeed * Time.fixedDeltaTime);
    }
}
