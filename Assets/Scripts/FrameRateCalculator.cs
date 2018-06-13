using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrameRateCalculator : MonoBehaviour {
    //variable texte
    public Text frameRateText;

    //variable pour le calcul des FPS
    private int m_frameCounter = 0;
    private float m_timeCounter = 0.0f;
    public float m_refreshTime = 1.0f;
    private float m_actualFrameRate = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //approximatif trop rapide à l'affichage
        //frameRateText.text = (1.0f / Time.deltaTime).ToString();

        if(m_timeCounter < m_refreshTime)
        {
            m_timeCounter += Time.deltaTime;
            m_frameCounter++;

        }else
        {
            m_actualFrameRate = (float) m_frameCounter / m_timeCounter;
            m_frameCounter = 0;
            m_timeCounter = 0;
            frameRateText.text = m_actualFrameRate.ToString();
        }

	}
}
