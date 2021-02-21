using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _pointButtonGameObject = default;

    [SerializeField]
    private Canvas _parentCanvas = default;

    public void SpawnButton(){
        Instantiate(_pointButtonGameObject);
    }
}
