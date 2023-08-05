using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private CharacterController _ch;
    [SerializeField] private float _speed;

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
