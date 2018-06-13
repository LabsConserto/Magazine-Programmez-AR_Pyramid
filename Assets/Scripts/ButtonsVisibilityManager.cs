using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsVisibilityManager : MonoBehaviour {

    #region PUBLIC_MEMBERS_VARIABLES
    public Button buttonPyramide, buttonCrossSectionPyramid, buttonSphynx;
    public GameObject ImageTarget_Pyramid;
    #endregion

    #region PRIVATE_MEMBER_VARIABLES
    DefaultTrackableEventHandler PyramideScript;
    #endregion // PRIVATE_MEMBER_VARIABLES

    #region MONOBEHAVIOUR_METHODS
    // Use this for initialization
    void Start () {
        PyramideScript = ImageTarget_Pyramid.GetComponent<DefaultTrackableEventHandler>();
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log("PyramideScript ref bool : " + PyramideScript.IsTracked);

        if (PyramideScript.IsTracked)
        {
            Debug.Log("Pyramide traquée");
            buttonPyramide.gameObject.SetActive(true);
            buttonCrossSectionPyramid.gameObject.SetActive(true);
            buttonSphynx.gameObject.SetActive(true);
        }

        if (!PyramideScript.IsTracked)
        {
            Debug.Log("Pyramide plus traquée");
            buttonPyramide.gameObject.SetActive(false);
            buttonCrossSectionPyramid.gameObject.SetActive(false);
            buttonSphynx.gameObject.SetActive(false);

        }
    }
    #endregion
}
