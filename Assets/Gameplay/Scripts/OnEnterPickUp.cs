using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class OnEnterPickUp : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private GameObject _flower;


    private SphereCollider _sphereCollider;

    private void Awake()
    {
        _sphereCollider = GetComponent<SphereCollider>();
        _sphereCollider.isTrigger = true;
        _sphereCollider.radius = _radius;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent<HandedBobr>(out var bobr))
        {
            bobr.PickUp();
            _flower.SetActive(true);
            Destroy(gameObject);
        }
    }
}
