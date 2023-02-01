using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public int Level_Index = 0;
    private int i;

    private void Awake()
    {
        i = 0;
        //levelPanels[i].SetActive(true);
        
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    //public void Next_Level()
    //{
    //    Motorcycle_Controller.isControllable = true;
    //    //Level_Index++;

    //    for (int i = 0; i < levelPanels.Length; i++)
    //    {
    //        if (i == Level_Index)
    //        {
    //            levelPanels[Level_Index].SetActive(true);
    //            //Instantiate(levelPanels[i], this.transform.position, Quaternion.identity);
    //            Debug.Log(Level_Index);
    //            Debug.Log(i);
    //        }
    //        else
    //        {
    //            levelPanels[Level_Index].SetActive(false);
    //        }
    //    }
    //}
}
