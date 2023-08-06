using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSystem : MonoBehaviour
{
    [SerializeField] private CharacterController _player;
    [SerializeField] private CameraController _camera;
    [SerializeField] private GameObject _flower;

    private List<Checkpoint> _checkpoints = new List<Checkpoint>();

    public void AddCheckpoint(Checkpoint checkpoint)
    {
        _checkpoints.Add(checkpoint);
    }

    public void GoToCheckpoint()
    {
        Debug.Log("GoToCheck");
        _checkpoints[_checkpoints.Count - 1].Activate(_player, _camera, _flower);
    }
}
