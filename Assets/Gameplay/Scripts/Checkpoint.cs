using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private List<GameObject> _objectsToActive;
    [SerializeField] private Transform _playerSpawnPoint;
    [SerializeField] private Transform _flowerSpawnPoint;
    [SerializeField] private CheckpointSystem _checkpointSystem;

    public void Activate(CharacterController player, CameraController camera, GameObject flower)
    {

        player.enabled = false;
        player.transform.position = _playerSpawnPoint.position;
        camera.transform.rotation = _playerSpawnPoint.rotation;
        player.enabled = true;


        flower.transform.position = _flowerSpawnPoint.position;
        flower.transform.rotation = _flowerSpawnPoint.rotation;

        foreach (GameObject obj in _objectsToActive)
        {
            obj.SetActive(true);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<PlayerController>(out var player))
        {
            _checkpointSystem.AddCheckpoint(this);
            Destroy(gameObject.GetComponent<BoxCollider>());
        }
    }
}