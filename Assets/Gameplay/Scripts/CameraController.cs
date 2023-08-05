using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _body;
    [SerializeField] private float _cameraSentivity;
    [SerializeField] private Vector3 _offset = new Vector3(0, 1, 0);

    private float xRotation;
    private float yRotation;

    private void FixedUpdate()
    {
        transform.position = _body.position + _offset;

        MoveCamera();
    }

    private void MoveCamera()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * _cameraSentivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * _cameraSentivity;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        _body.transform.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
