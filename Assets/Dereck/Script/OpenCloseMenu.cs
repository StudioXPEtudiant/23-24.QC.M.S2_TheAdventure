using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseMenu : MonoBehaviour
{
    public GameObject _mainMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _mainMenu.gameObject.SetActive(!_mainMenu.gameObject.activeSelf);
        }
    }
    
    public void ClosingMenu()
    {
        _mainMenu.gameObject.SetActive(false);
    }

    
    
}
