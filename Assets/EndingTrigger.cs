using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _endingCanvas;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<PlayerController>())
        {
            _endingCanvas.SetActive(true);
        }
    }
}
