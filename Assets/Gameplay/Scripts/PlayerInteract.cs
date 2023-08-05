using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private LayerMask _raycastMask;
    [SerializeField] private float _interactDistance = 2.5f;
    [SerializeField] private Animator _anim;

    private AttackType _attackType;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _attackType = AttackType.BreakingWood;
            ThrowRaycast();
        }

        if (Input.GetMouseButton(1))
        {
            _attackType = AttackType.BreakingGrass;
            ThrowRaycast();
        }
    }

    private void ThrowRaycast()
    {
        RaycastHit hitInfo = new RaycastHit();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        bool hit = Physics.Raycast(ray, out hitInfo, _interactDistance, _raycastMask);

        if (hit)
        {
            GameObject hitObject = hitInfo.transform.gameObject;

            if(hitObject.TryGetComponent<BreakableObject>(out var obj))
            {
                obj.Interact(_attackType);
            }

            //if (hitObject.TryGetComponent<Bober>(out var bober))
            //{
            //    bober.PickUp();
            //}
        }
    }
}
