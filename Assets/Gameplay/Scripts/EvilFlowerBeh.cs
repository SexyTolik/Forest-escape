using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EvilFlowerBeh : MonoBehaviour
{
    [SerializeField] private PlayerController Target;
    [SerializeField] private CameraController Camera;


    private NavMeshAgent meshAgent;

    void Start()
    {
        meshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (meshAgent.enabled)
            meshAgent.SetDestination(Target.transform.position);
    }

    private IEnumerator RotateToFlower()
    {
        meshAgent.enabled = false;
        Target.enabled = false;
        Camera.enabled = false;

        Camera.transform.LookAt(gameObject.transform.position + new Vector3(0, 1,0));

        GetComponent<Animator>().SetTrigger("Attak");

        yield return new WaitForSeconds(1f);

        Camera.enabled = true;
        Target.enabled = true;
        meshAgent.enabled = true;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(RotateToFlower());
        }
    }
}
