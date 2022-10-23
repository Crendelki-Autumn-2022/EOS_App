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
                if (item.CompareTag("panel"))
                {
                    bar.SetActive(true);
                    print(bar.name);
                    print(bar.activeSelf);
                }
            }
            else{
                item.SetActive(false);
                if (!item.CompareTag("panel"))
                    bar.SetActive(false);
            }
        }
    }



}
