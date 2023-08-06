using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _playerObj;

    private void Awake()
    {
        _playerObj.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        _playerObj.SetActive(true);
        gameObject.SetActive(false);
    }
}
