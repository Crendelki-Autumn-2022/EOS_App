using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RashavellyScript : MonoBehaviour
{
    public List<GameObject> panels = new List<GameObject>();
    public GameObject bar;


    public void mainMenuGo(GameObject panel)
    {
        foreach (GameObject item in panels)
        {
            if(item==panel){
                item.SetActive(true);
                if(item.CompareTag("panel")) bar.SetActive(true);
            }
            else{
                item.SetActive(false);
                bar.SetActive(false);
            }
        }
    }



}
