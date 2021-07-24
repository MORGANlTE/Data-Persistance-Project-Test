using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript Instance;
    public static string naam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public string getNaam()
    {
        return naam;
    }

    // Update is called once per frame
    private void Awake() {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void setName(string name) {
        {
            naam = name;
            Debug.Log("Name set to " + naam);
        }
    }
}
