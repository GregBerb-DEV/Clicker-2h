using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlobScript : MonoBehaviour
{
    public static int _scoreIncrement = 1;
    [SerializeField] private float _buttonLifespan = 3;
    private Button _button;
    private float _startTime;

    void Start()
    {
        _button = gameObject.GetComponent<Button>();
        _startTime = Time.time;
    }

    private void Update()
    {
        if (Time.time >= _startTime + _buttonLifespan)
            Destroy(gameObject);
    }

    public void UpdateScore(int _PlusHightScore)
    {
        LeftPanel.Instance.UpdateScore(_scoreIncrement);
        Destroy(gameObject);
    }


}

