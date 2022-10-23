using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutor : MonoBehaviour
{
    public int nextSlide = 1;
    public int previousSlide = 0;

    public List<GameObject> tutors = new List<GameObject>();

    public GameObject tutorPanel;
    public GameObject documents;
    public GameObject LK;

    public void switchTutors()
    {
        if (nextSlide < 15)
        {
            tutors[nextSlide].SetActive(true);
            tutors[previousSlide].SetActive(false);
            previousSlide += 1;
            nextSlide += 1;

            if (nextSlide == 4)
            {
                documents.SetActive(true);
            }

            if (nextSlide == 9)
            {
                documents.SetActive(false);
            }

            if (nextSlide == 11)
            {
                LK.SetActive(true);
            }
        }
        else
        {
            tutorPanel.SetActive(false);
            LK.SetActive(false);
        }
    }

    public void skipTutors()
    {
        tutorPanel.SetActive(false);
        documents.SetActive(false);
        LK.SetActive(false);
    }
}
