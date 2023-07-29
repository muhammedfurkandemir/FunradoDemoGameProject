using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.VersionControl;

public class LevelController : MonoBehaviour
{
    public int Level = 1;
    public TextMeshProUGUI _textMeshProUGUI;
    void Start()
    {
        _textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    public void SetLevel(GameObject go)
    {
        Level++;
        _textMeshProUGUI.text = "Lv."+ Level;
    }
    
}
