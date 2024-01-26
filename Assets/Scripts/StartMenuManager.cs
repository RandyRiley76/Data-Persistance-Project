using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class StartMenuManager : MonoBehaviour
{
    public Button StartButton;
    public Button QuitButton;
    public InputField NameInput;
    public GameManager gameManager;

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
        Debug.Log("You Hit Quit");
    }

    // Start is called before the first frame update
    void Start()
    {
 
        StartButton.onClick.AddListener(LoadGameScene);
         QuitButton.onClick.AddListener(QuitGame);

       //  SET INPUT FIELD
        if (GameManager.userName == "default user") {
            NameInput.text = "Enter Your Name";
        } else {
            NameInput.text = GameManager.userName;    
        }
       // Debug.Log(GameManager.userName);
    }


    // Update is called once per frame
    void Update()
    {
      
    }
}
//CODE GRAVEYARD//Should have worked the first time, but that would be too easy////
// Debug.Log(GameManager.Instance.GetComponent<GameManager>().userName);
//  Debug.Log(gameManager.GetComponent<GameManager>().);
//  mainManager = GameObject.Find("MainManager").GetComponent<MainManager>();
//var userName = MainManager.Instance.GetComponent<MainManager>().userName;