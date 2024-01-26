using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRollover : MonoBehaviour
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
    // Update is called once per frame
    void Update()
    {
        
    }
}
