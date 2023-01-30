using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public GameObject[] levelPanels;

    public GameObject MotorBike;

    public GameObject FinishPanel;
    private int currentLevelIndex = 0;

    private void Start()
    {
        //Instantiate(MotorBike, levelPanels[0].transform.position, Quaternion.identity);
    }

    public void NextLevel()
    {
        currentLevelIndex++;

        if (currentLevelIndex >= levelPanels.Length)
        {
            currentLevelIndex = 0;
        }

        for (int i = 0; i < levelPanels.Length; i++)
        {
            if (i == currentLevelIndex)
            {
                levelPanels[i].SetActive(true);
                MotorBike.transform.position = levelPanels[i].transform.position;
                //Instantiate(MotorBike, levelPanels[i].transform.position, Quaternion.identity);
                FinishPanel.SetActive(false);
            }
            else
            {
                levelPanels[i].SetActive(false);
            }
        }
    }
}
