using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSystem : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _flower;

    private List<Checkpoint> _checkpoints = new List<Checkpoint>();

    public void GoToCheckpoint()
    {
        _checkpoints[_checkpoints.Count - 1].Activate(_player, _flower);
    }
}
