using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetsManager : MonoBehaviour
{

    public GameObject pyramid_crossSection;
    public GameObject sphynx;
    public GameObject pyramid;

    // Use this for initialization
    void Start()
    {

    }

    #region PUBLIC_METHODS
    public void HandleVirtualButtonPressed_Pyramid_CrossSection()
    {
        Debug.Log("A button has been slain ! (CrossSection)");
        if (!pyramid_crossSection.activeInHierarchy)
        {
            pyramid_crossSection.SetActive(true);
            pyramid.SetActive(false);
            sphynx.SetActive(false);
        }
    }

    public void HandleVirtualButtonPressed_Pyramid_Sphynx()
    {
        Debug.Log("A button has been slain ! (Sphynx)");
        if (!sphynx.activeInHierarchy)
        {
            pyramid_crossSection.SetActive(false);
            pyramid.SetActive(false);
            sphynx.SetActive(true);
        }
    }

    public void HandleVirtualButtonPressed_Pyramid_Full()
    {
        Debug.Log("A button has been slain ! (Full) ");
        if (!pyramid.activeInHierarchy)
        {
            pyramid_crossSection.SetActive(false);
            pyramid.SetActive(true);
            sphynx.SetActive(false);
        }
    }

    public void HandleVirtualButtonReleased()
    {
        Debug.Log("A button has been release ! ");

    }
    #endregion // PUBLIC_METHODS
}
