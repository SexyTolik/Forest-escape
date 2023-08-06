using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteBillboard : MonoBehaviour
{
    [SerializeField] private bool _canRotateAll = false;

    void Update()
    {

        if(_canRotateAll)
        {
            transform.rotation = Camera.main.transform.rotation;

        }
        else
        {
            transform.rotation = Quaternion.Euler(0, Camera.main.transform.rotation.eulerAngles.y, 0);
            transform.Rotate(new Vector3(transform.localRotation.x, 0, transform.localRotation.z));
        }
    }
}
