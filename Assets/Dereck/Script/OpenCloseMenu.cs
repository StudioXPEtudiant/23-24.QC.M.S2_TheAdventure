using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseMenu : MonoBehaviour
{

    
    public GameObject _mainMenu; 
    public GameObject _mapMenu;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _mainMenu.gameObject.SetActive(!_mainMenu.gameObject.activeSelf);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            _mapMenu.gameObject.SetActive(!_mapMenu.gameObject.activeSelf);
        }
    }
    
    public void ClosingMainMenu()
    {
        _mainMenu.gameObject.SetActive(false);
    }
    
    public void ClosingMapMenu()
    {
        _mapMenu.gameObject.SetActive(false);
    }

    
    
}
