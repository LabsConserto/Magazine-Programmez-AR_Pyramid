/*===============================================================================
Copyright (c) 2015-2017 PTC Inc. All Rights Reserved.

Copyright (c) 2015 Qualcomm Connected Experiences, Inc. All Rights Reserved.

Vuforia is a trademark of PTC Inc., registered in the United States and other 
countries.
===============================================================================*/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class Trigger2D : MonoBehaviour
{

    #region PUBLIC_MEMBER_VARIABLES
    public Button ToVRButton;
    #endregion // PUBLIC_MEMBER_VARIABLES

    #region PRIVATE_MEMBER_VARIABLES
    // Activate transition from AR to VR or vice versa
    bool goingBackToAR = false;
    TransitionManager mTransitionManager;
    TextMeshProUGUI mText;
    #endregion // PRIVATE_MEMBER_VARIABLES

    #region MONOBEHAVIOUR_METHODS
    void Start()
    {
        mTransitionManager = FindObjectOfType<TransitionManager>();
        ToVRButton.onClick.AddListener(GoToVRActionOnClick);
        mText = ToVRButton.GetComponentInChildren<TextMeshProUGUI>();
    }
    #endregion // MONOBEHAVIOUR_METHODS


    #region PRIVATE_METHODS

    private void GoToVRActionOnClick()
    {
        if (goingBackToAR)
        {
            mText.SetText("Vue VR");
        }
        else
        {
            mText.SetText("Vue AR");
        }

        mTransitionManager.Play(goingBackToAR);

        goingBackToAR = !goingBackToAR;
    }   
    #endregion // PRIVATE_METHODS
}

