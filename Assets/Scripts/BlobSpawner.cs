using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobSpawner : MonoBehaviour
{
    public static BlobSpawner Instance;
    [SerializeField]
    private GameObject _blobGameObject = default;
    [SerializeField]
    private RectTransform _parentPanelTransform;
    [SerializeField] private int _minSpawnX;
    [SerializeField] private int _maxSpawnX;
    [SerializeField] private int _minSpawnY;
    [SerializeField] private int _maxSpawnY;
    public float _minSpawnTime;
    public float _maxSpawnTime;

    private float Timer;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        SpawnButton();
        Timer = Random.Range(_minSpawnTime, _maxSpawnTime);
    }

    private void Update()
    {
        if (Timer < Time.time)
        {
            SpawnButton();

            Timer += Random.Range(_minSpawnTime, _maxSpawnTime);
        }

    }

    public void SpawnButton()
    {
        int spawnX = Random.Range(_minSpawnX, _maxSpawnY);
        int spawnY = Random.Range(_minSpawnY, _maxSpawnY);
        Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0);

        GameObject _instantiatedBlob = Instantiate(_blobGameObject, new Vector3(0, 0, 0), Quaternion.identity, _parentPanelTransform);
        _instantiatedBlob.GetComponent<RectTransform>().localPosition = spawnPosition;
    }
}
