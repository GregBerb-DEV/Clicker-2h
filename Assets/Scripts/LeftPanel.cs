using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LeftPanel : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI _scoreDisplay = default;

    public int _currentScore;

    void UpdateScore(int _PlusHightScore){
        _scoreDisplay.SetText($"Stars: {_currentScore + _PlusHightScore}");
    }
}
