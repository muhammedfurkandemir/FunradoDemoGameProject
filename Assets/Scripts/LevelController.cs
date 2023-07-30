using UnityEngine;
using TMPro;

public class LevelController : MonoBehaviour
{
    public int Level = 1;
    public TextMeshProUGUI _textMeshProUGUI;
    public Item item;
    void Start()
    {
        _textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    public void SetLevel(GameObject go)
    {
        Level += item.upgradeLevel;
        _textMeshProUGUI.text = "Lv."+ Level;
    }
    
}
