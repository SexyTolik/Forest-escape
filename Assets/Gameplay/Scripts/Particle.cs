using System.Collections;
using UnityEngine;

public class Particle : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;

    public IEnumerator PlayParticle()
    {
        _particleSystem.Play();

        yield return new WaitForSeconds(1f);

        Destroy(this.gameObject);
    }
}