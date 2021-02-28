using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aumento : MonoBehaviour
{
    [SerializeField] private int _cost = 10;
    [SerializeField] private int _scoreBonus = 1;

    public void ApplyEffect()
    {
        if (LeftPanel.Instance._currentScore - _cost >= 0)
        {
            LeftPanel.Instance._currentScore -= _cost;
            LeftPanel.Instance.UpdateScoreText();
            BlobScript._scoreIncrement += _scoreBonus;
        }
    }
}
