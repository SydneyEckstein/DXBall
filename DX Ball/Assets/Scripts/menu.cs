using UnityEngine;
using TMPro;
using UnityEngine.UI; // Required for UI elements
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonClick()
    {
        SceneManager.LoadScene("Level1");

    }
}
