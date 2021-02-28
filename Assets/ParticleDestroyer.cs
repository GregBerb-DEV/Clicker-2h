using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroyer : MonoBehaviour
{
    [SerializeField] private float _lifeSpan = 1f;
    private float _spawnTime;

    private void Awake()
    {
        _spawnTime = Time.time;
    }

    private void Update()
    {
        if (Time.time >= _spawnTime - _lifeSpan)
            Destroy(gameObject);
    }
}
