using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonQuit : MonoBehaviour
{
    public Material rollOverMat;
    public Material buttonMat;

    private void OnMouseEnter()
    {
        gameObject.GetComponent<Renderer>().material = rollOverMat;
    }
    private void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material = buttonMat;
    }
    private void OnMouseDown()
    {
        Debug.Log("You Hit Quit");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
