using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class StartMenuManager : MonoBehaviour
{
    public Button StartButton;
    public Button QuitButton;
    public InputField NameInput;
    public TextMeshProUGUI HighScoreText;
    public GameManager gameManager;


    public void LoadGameScene()
    {
        if (NameInput.text == "Enter Your Name")
            { GameManager.userName = "Outstanding Citizen"; }
        else {
            GameManager.userName = NameInput.text;
            gameManager.SaveData();
        }
      // Debug.Log(GameManager.userName);
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        gameManager.SaveData();
       //THIS ALLOW YOU TO TEST QUITTING ALONG WITH THE NAMESPACE DECLARATION PART
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }


    // Start is called before the first frame update
    void Start()
    {
        // REGISTER MOUSE CLICKS
        StartButton.onClick.AddListener(LoadGameScene);
         QuitButton.onClick.AddListener(QuitGame);

       //  SET INPUT FIELD
        if (GameManager.userName == "default user") {
            NameInput.text = "Enter Your Name";
        } else {
            NameInput.text = GameManager.userName;    
        }
        // SET HIGHSCORE
        HighScoreText.text = "Best Score :: " + GameManager.highScoreUser +" :: "  + GameManager.highScore;
    }


}
//CODE GRAVEYARD//Should have worked the first time, but that would be too easy////
// Debug.Log(GameManager.Instance.GetComponent<GameManager>().userName);
//  Debug.Log(gameManager.GetComponent<GameManager>().);
//  mainManager = GameObject.Find("MainManager").GetComponent<MainManager>();
//var userName = MainManager.Instance.GetComponent<MainManager>().userName;