using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlobScript : MonoBehaviour
{
    private Button _button; 

    void Start()
    {
        _button = gameObject.GetComponent<Button>();
    }

    public void UpdateScore(int _PlusHightScore){
        LeftPanel.Instance.UpdateScore(_PlusHightScore);
    }

    
}

