using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Running");
    }

    private void Awake()  //Script Enabled/Disabled 
    {
        Debug.Log("Awake Running");
    }

    // Update is called once per frame
    /*void Update()
    {
        Debug.Log("Update Running");
    }*/

    private void FixedUpdate() //อะไรที่เกี่ยวกับ ฟิชิก, เวลา นำมาเขียนในนี้เลย
    {
        Debug.Log("FixedUpdate Running");
    }

    private void LateUpdate() //จะทำงานหลัง อัพเดตเสร็จ
    {
        Debug.Log("LateUpdate Running");
    }
}
