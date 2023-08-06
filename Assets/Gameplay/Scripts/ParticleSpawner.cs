using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
    [SerializeField] private Particle _woodParticlePrefab;
    [SerializeField] private Particle _grassParticlePrefab;

    public void SpawnParticle(AttackType attackType, Vector3 position)
    {

        switch (attackType)
        {
            case AttackType.BreakingWood:
                Particle woodParticle = Instantiate(_woodParticlePrefab, position, Quaternion.identity, transform);
                woodParticle.PlayParticle();
                break;
            case AttackType.BreakingGrass:
                Particle grassParticle = Instantiate(_grassParticlePrefab, position, Quaternion.identity, transform);
                grassParticle.PlayParticle();
                break;
        }
    }
}
