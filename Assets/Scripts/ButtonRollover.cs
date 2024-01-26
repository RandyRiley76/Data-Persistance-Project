using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRollover : MonoBehaviour
{
    public Material rollOverMat;
    public Material buttonMat;
    private Coroutine startFlashing;
    private bool shouldFlash = false;

    private IEnumerator FlashThemBalls() {
        while (shouldFlash) {
        gameObject.GetComponent<Renderer>().material = rollOverMat;
        yield return new WaitForSecondsRealtime(.3f);
        gameObject.GetComponent<Renderer>().material = buttonMat;
            yield return new WaitForSecondsRealtime(.1f);
        }
    }
    private void OnMouseEnter()
    {
        shouldFlash = true;
        startFlashing = StartCoroutine(FlashThemBalls());
    }
    private void OnMouseExit()
    {
        shouldFlash = false;
        gameObject.GetComponent<Renderer>().material = buttonMat;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
