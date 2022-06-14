using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(Time.timeScale == 1)
            {
                //Pause
                Time.timeScale = 0;
            }
            else
            {
                //Continue
                Time.timeScale = 1; 
            }
        }
    }
}
