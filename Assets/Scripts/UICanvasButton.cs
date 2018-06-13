using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class UICanvasButton : MonoBehaviour, IEventSystemHandler
{

    #region PUBLIC_MEMBERS_VARIABLES
    public Button buttonPyramide, buttonCrossSectionPyramid, buttonSphynx;
    public GameObject pyramid, pyramidCrossSection, sphynx, ImageTarget_Pyramid;
    #endregion

    #region PRIVATE_MEMBER_VARIABLES

    #endregion // PRIVATE_MEMBER_VARIABLES

    #region MONOBEHAVIOUR_METHODS
    // Use this for initialization
    void Start () {

        //adding action to listener of the button
        buttonPyramide.onClick.AddListener(TaskOnClickPyramid);
        buttonCrossSectionPyramid.onClick.AddListener(TaskOnClickPyramidCrossSection);
        buttonSphynx.onClick.AddListener(TaskOnClickSphynx);
    }
    #endregion

    #region PUBLIC METHODS

    #endregion //PUBLIC METHODS

    #region PRIVATE_METHODS

    void TaskOnClickPyramid()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button pyramid!");
        pyramid.SetActive(true);
        pyramidCrossSection.SetActive(false);
        sphynx.SetActive(false);
    }

    void TaskOnClickPyramidCrossSection()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button CrossSection!");
        pyramid.SetActive(false);
        pyramidCrossSection.SetActive(true);
        sphynx.SetActive(false);
    }

    void TaskOnClickSphynx()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button Sphynx!");
        pyramid.SetActive(false);
        pyramidCrossSection.SetActive(false);
        sphynx.SetActive(true);
    }
    #endregion
}
