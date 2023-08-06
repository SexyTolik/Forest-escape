using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EvilFlowerBeh : MonoBehaviour
{
    [SerializeField] private GameObject Target;
    [SerializeField] private CameraController Camera;


    private NavMeshAgent meshAgent;

    void Start()
    {
        meshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        meshAgent.SetDestination(Target.transform.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Camera.transform.LookAt(gameObject.transform);

            GetComponent<Animator>().SetTrigger("Attak");
        }
    }
}
