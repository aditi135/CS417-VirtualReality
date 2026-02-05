using UnityEngine;
using UnityEngine.InputSystem;

public class QuitApplication : MonoBehaviour
{
    public InputActionReference action;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            QuitApp();
        };
    }

    // Update is called once per frame
    void Update()
    {
        // keyboard fallback for testing without HMD
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitApp();
        }
        
    }

    void QuitApp()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif    
    }

}
