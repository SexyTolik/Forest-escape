using UnityEngine;

public class HandedBobr : MonoBehaviour
{
    public bool IsBobrInHand => _isBobrInHand;

    [SerializeField] private GameObject _bobrObj;


    private  bool _isBobrInHand = false;

    public void PickUp()
    {
        _isBobrInHand = true;
        _bobrObj.SetActive(true);
    }
}
