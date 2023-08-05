using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EvilFlowerBeh : MonoBehaviour
{
    [SerializeField] private GameObject Target;
    private NavMeshAgent meshAgent;

    // Start is called before the first frame update
    void Start()
    {
        meshAgent= GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        meshAgent.SetDestination(Target.transform.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<Animator>().SetTrigger("Attak");
        }
    }
}
