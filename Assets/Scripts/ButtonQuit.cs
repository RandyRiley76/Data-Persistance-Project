using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonQuit : MonoBehaviour
{
    public Material rollOverMat;
    public Material buttonMat;
    public StartMenuManager StartMenuManager;

    private void OnMouseEnter()
    {
      //  gameObject.GetComponent<Renderer>().material = rollOverMat;
      // MADE A ROLLOVER SCRIPT FOR BOTH BALLS FOR FLASHING
    }
    private void OnMouseExit()
    {
      //  gameObject.GetComponent<Renderer>().material = buttonMat;
    }
    private void OnMouseDown()
    {
        StartMenuManager.QuitGame();
       // Debug.Log("You Hit Quit");

    }
    // Start is called before the first frame update
    void Start()
    {
        StartMenuManager = StartMenuManager.GetComponent<StartMenuManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
