using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUI : MonoBehaviour
{

    public GameManagerScript gameManagerScript;
    public TMP_InputField nameField;
    private void Start() {
        gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
    }
    public void startGame()
    {
        SceneManager.LoadScene(1);
        gameManagerScript.setName(nameField.text);
    }
}
