using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private LayerMask _raycastMask;
    [SerializeField] private float _interactDistance = 2.5f;
    [SerializeField] private Animator _anim;
    [SerializeField] private HandedBobr _handedBobr;
    [SerializeField] private ParticleSpawner _particleSpawner;

    private void Update()
    {
        if(_handedBobr.IsBobrInHand)
        {
            if(Input.GetMouseButton(0) || Input.GetMouseButton(1))
            {
                if (Input.GetMouseButton(0))
                {
                    ThrowRaycast(AttackType.BreakingWood);
                    _anim.SetInteger("Input", 1);
                }

                if (Input.GetMouseButton(1))
                {
                    ThrowRaycast(AttackType.BreakingGrass);
                    _anim.SetInteger("Input", 2);
                }
            }
            else
            {
                _anim.SetInteger("Input", 0);
            }

        }
    }

    private void ThrowRaycast(AttackType attackType)
    {
        RaycastHit hitInfo = new RaycastHit();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        bool hit = Physics.Raycast(ray, out hitInfo, _interactDistance, _raycastMask);

        if (hit)
        {
            GameObject hitObject = hitInfo.transform.gameObject;

            if(hitObject.TryGetComponent<BreakableObject>(out var obj))
            {
                bool isBreakSucces = obj.Interact(attackType);

                if (isBreakSucces) _particleSpawner.SpawnParticle(attackType, hitInfo.point);
            }
        }
    }
}
