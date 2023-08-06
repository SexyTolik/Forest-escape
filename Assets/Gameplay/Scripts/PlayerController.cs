using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private CharacterController _ch;
    public float _defaultSpeed;
    public float _speed;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    private void OnEnable()
    {
        _speed = _defaultSpeed;
    }

    private void FixedUpdate()
    {
        Walk();
    }

    private void Walk()
    {
        float hr = Input.GetAxisRaw("Horizontal");
        float vr = Input.GetAxisRaw("Vertical");

        Vector3 movement = _ch.transform.forward * vr + _ch.transform.right * hr;
        _ch.Move(movement * _speed * Time.fixedDeltaTime);
    }
}
