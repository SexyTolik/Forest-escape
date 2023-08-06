using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _woodParticlePrefab;
    [SerializeField] private Particle _grassParticlePrefab;

    public void SpawnParticle(AttackType attackType, Vector3 position)
    {

        switch (attackType)
        {
            case AttackType.BreakingWood:
                Instantiate(_woodParticlePrefab, position, Quaternion.identity);
                break;
            case AttackType.BreakingGrass:
                Particle grassParticle = Instantiate(_grassParticlePrefab, position, Quaternion.identity, transform);
                grassParticle.PlayParticle();
                break;
        }
    }
}
