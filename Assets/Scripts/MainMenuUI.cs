using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenuUI : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] TMP_InputField playerName;
    [SerializeField] TextMeshProUGUI bestRecord;
    void Start()
    {
        if(GameManager.instance != null)
        {
            bestRecord.text = $"Best Score: {GameManager.instance.bestScore} Name: {GameManager.instance.bestPlayerName}";
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        GameManager.instance.playerName = playerName.text;
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
