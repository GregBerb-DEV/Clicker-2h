using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlobScript : MonoBehaviour
{
    public static int _scoreIncrement = 1;
    private Button _button;

    void Start()
    {
        _button = gameObject.GetComponent<Button>();
    }

    public void UpdateScore(int _PlusHightScore)
    {
        LeftPanel.Instance.UpdateScore(_scoreIncrement);
    }


}

