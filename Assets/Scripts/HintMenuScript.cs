using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintMenuScript : MonoBehaviour {

    #region PUBLIC_MEMBER_VARIABLES
    public Button HintButton;
    public GameObject HintText;
    #endregion // PUBLIC_MEMBER_VARIABLES

    #region PRIVATE_MEMBER_VARIABLES

    #endregion // PRIVATE_MEMBER_VARIABLES

    #region MONOBEHAVIOUR_METHODS
    void Start()
    {
        HintText.SetActive(false);
        HintButton.onClick.AddListener(HintActionOnClick);
    }
    #endregion // MONOBEHAVIOUR_METHODS


    #region PRIVATE_METHODS
    private void HintActionOnClick()
    {
        HintText.SetActive(!HintText.activeInHierarchy);
    }
    #endregion // PRIVATE_METHODS
}
