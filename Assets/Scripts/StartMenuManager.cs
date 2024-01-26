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
    private MainManager mainManager;

    public void LoadGameScene()
    {
        Debug.Log("Hey");
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Debug.Log("You Hit Quit");
    }

    // Start is called before the first frame update
    void Start()
    {
      //  mainManager = GameObject.Find("MainManager").GetComponent<MainManager>();
      //var userName = MainManager.Instance.GetComponent<MainManager>().userName;
        StartButton.onClick.AddListener(LoadGameScene);
         QuitButton.onClick.AddListener(QuitGame);
        Debug.Log(MainManager.Instance.userName);
     //   Debug.Log(mainManager.userName);
        /*/ SET INPUT FIELD
        if (MainManager.Instance.userName == "default user") {
            NameInput.text = "Outstanding Citizen";
        } else {
            NameInput.text = MainManager.Instance.userName;    
        }//*/
       
    }


    // Update is called once per frame
    void Update()
    {
      
    }
}
