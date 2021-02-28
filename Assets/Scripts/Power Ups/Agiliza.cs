using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agiliza : MonoBehaviour
{
    [SerializeField] private int _cost = 10;
    [SerializeField] private int _spawnTimeModifier;

    public void ApplyEffect()
    {
        if (LeftPanel.Instance._currentScore - _cost > 0)
        {
            LeftPanel.Instance._currentScore -= _cost;
            LeftPanel.Instance.UpdateScoreText();
            BlobSpawner.Instance._minSpawnTime -= BlobSpawner.Instance._minSpawnTime / _spawnTimeModifier;
            BlobSpawner.Instance._maxSpawnTime -= BlobSpawner.Instance._maxSpawnTime / _spawnTimeModifier;
        }
    }
}
