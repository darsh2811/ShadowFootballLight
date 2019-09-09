using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
   public bool isActive;

    public GameObject[] totalLights;
    // Start is called before the first frame update
    void Start()
    {
       this.isActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnOnOfLight(int i)
    {
        //LightsOn();
         //OnOff.instance.isActive = !OnOff.instance.isActive;
         //this.isActive = !this.isActive;
        totalLights[i].GetComponent<OnOff>().isActive = !totalLights[i].GetComponent<OnOff>().isActive;
        totalLights[i].SetActive(totalLights[i].GetComponent<OnOff>().isActive);
        
    }

    void LightsOn()
    {
        for(int i=0;i<totalLights.Length;i++)
        {
            totalLights[i].SetActive(true);
        }
    }
}
