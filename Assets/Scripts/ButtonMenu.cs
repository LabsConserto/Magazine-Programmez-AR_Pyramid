using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMenu : MonoBehaviour {

    #region PUBLIC_MEMBER_VARIABLES
    public GameObject sideMenu;
    public Button menuButton;
    #endregion

    #region MONOBEHAVIOUR_METHODS
    // Use this for initialization
    void Start () {
        sideMenu.SetActive(false);
        menuButton.onClick.AddListener(ActionOnMenuButtonClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    #endregion

    #region PRIVATE_METHODS
    void ActionOnMenuButtonClick()
    {
        Debug.Log("Menu has been open ?" + sideMenu.activeInHierarchy);
        sideMenu.SetActive(!sideMenu.activeInHierarchy);
    }
    #endregion
}
