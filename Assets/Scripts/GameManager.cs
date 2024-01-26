using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;//FOR SAVING DATA TO DISK

public class GameManager : MonoBehaviour
{
    public static string userName = "default user";
    public static int highScore = 0;
    public static string highScoreUser = "No Plays Yet";
    public static GameManager Instance;
    private void Awake()
    {
        //LOAD JSON FILE FOR BETWEEN SESSIONS
        LoadData();
        //FOR DATA PERSISTANCE BETWEEN SCENES
        //singleton pattern - makes sure there is only one instance
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    ///FOR SAVING BETWEEN SESSIONS
    [System.Serializable]//required for JSON to save file
    class HighScoreClass //Its a good idea to make a small class with just what is needed before saving JSON file
    {
        public string userName;
        public int highScore;
        public string highScoreUser;
    }


    public void SaveData()
    {
        HighScoreClass data = new HighScoreClass();
        data.highScore = highScore;
        data.highScoreUser = highScoreUser;
        data.userName = userName;

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

            userName = data.userName;
            highScore = data.highScore;
            highScoreUser = data.highScoreUser;

        }



    }
}
