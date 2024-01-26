using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static string userName = "default user";
    public static int highScore = 0;
    public static string highScoreUser = "No Plays Yet";
    public static GameManager Instance;
    private void Awake()
    {   //FOR DATA PERSISTANCE BETWEEN SCENES
        //singleton pattern - makes sure there is only one instance
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
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
