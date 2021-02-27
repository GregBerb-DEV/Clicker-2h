using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _blobGameObject = default;
    [SerializeField]
    private RectTransform _parentCanvasTransform;

    private void Start()
    {
        SpawnButton();
    }

    public void SpawnButton()
    {
        Instantiate(_blobGameObject, new Vector3(0, 0, 0), Quaternion.identity, _parentCanvasTransform);
    }
}
