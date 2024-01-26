using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;//FOR SAVING DATA TO DISK
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

    ///FOR SAVING BETWEEN SESSIONS
    [System.Serializable]//required for JSON to save file
    class HighScoreClass //Its a good idea to make a small class with just what is needed before saving JSON file
    {
        public string userName;
        public int highScore;
        public string highScoreUser; 
    }
 
    private void Awake()
    {
        LoadData();
    }

    public void SaveData()
    {
        HighScoreClass data = new HighScoreClass();
        data.highScore = GameManager.highScore;
        data.highScoreUser = GameManager.highScoreUser;
        data.userName = GameManager.userName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadData()
    {

        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            HighScoreClass data = JsonUtility.FromJson<HighScoreClass>(json);

            GameManager.userName = data.userName;
            GameManager.highScore = data.highScore;
            GameManager.highScoreUser = data.highScoreUser;
            
        }



    }
    public void LoadGameScene()
    {
        if (NameInput.text == "Enter Your Name")
            { GameManager.userName = "Outstanding Citizen"; }
        else {
            GameManager.userName = NameInput.text; }
       // Debug.Log("Hey");
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        SaveData();
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