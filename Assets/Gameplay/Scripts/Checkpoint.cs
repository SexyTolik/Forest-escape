using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private List<GameObject> _objectsToActive;
    [SerializeField] private Transform _playerSpawnPoint;
    [SerializeField] private Transform _flowerSpawnPoint;

    public void Activate(GameObject player, GameObject flower)
    {
        player.transform.position = _playerSpawnPoint.position;
        player.transform.rotation = _playerSpawnPoint.rotation;

        flower.transform.position = _flowerSpawnPoint.position;
        flower.transform.rotation = _flowerSpawnPoint.rotation;

        foreach (GameObject obj in _objectsToActive)
        {
            obj.SetActive(true);
        }
    }
}