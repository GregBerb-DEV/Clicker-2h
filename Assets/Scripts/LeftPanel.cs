﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LeftPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreDisplay = default;

    public static LeftPanel Instance;

    private void Awake(){
        if (Instance != null){
            Destroy(gameObject);
        }else
        {
            Instance = this;
        }
    }

    public int _currentScore;

    public void UpdateScore(int _PlusHightScore){
        _currentScore += _PlusHightScore;
        _scoreDisplay.SetText($"Stars: { _currentScore }");
    }
}
