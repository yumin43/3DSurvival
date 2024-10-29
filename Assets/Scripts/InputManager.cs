using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public GameObject settingPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            settingPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined; 
        }
    }

    public void OnClickBackButton()
    {
        Debug.Log("백버튼클릭");
        settingPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
