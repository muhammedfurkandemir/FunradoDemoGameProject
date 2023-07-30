using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public void LevelPass()
    {
        Debug.Log("Game level is pass.");
        textMeshPro.text = "Win! Level is pass.";
    }
    public void GameOver()
    {
        StartCoroutine(GameRestart());
        
    }
    
    IEnumerator GameRestart()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        StopCoroutine(GameRestart());
    }
}
