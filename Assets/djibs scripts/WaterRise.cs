using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRise : MonoBehaviour
{
    public int WaterLevel;
    public int MaxWaterLevel = 10;
    public GameObject[] levelIndicator;
    

    // Start is called before the first frame update
   
 

  void UpdateLevelIndicators()
    {
        for (int i = 0; i < levelIndicator.Length; i++)
        {
            if (i < WaterLevel)
            {
                // Set the color of the level indicator to blue
                Renderer renderer = levelIndicator[i].GetComponent<Renderer>();
                renderer.material.color = Color.blue;
            }
            else
            {
                // Set the color of the level indicator to white
                Renderer renderer = levelIndicator[i].GetComponent<Renderer>();
                renderer.material.color = Color.white;
            }
        }
    }
    void Update()
    {
        UpdateLevelIndicators();
    }
    public void IncreaseWaterLevel()
    {
        // Increase the water level by 1 (if it's not already at the maximum)
        if (WaterLevel < MaxWaterLevel)
        {
            WaterLevel++;
            UpdateLevelIndicators();
        }
    }
}
