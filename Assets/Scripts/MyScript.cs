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

    private void FixedUpdate() //���÷������ǡѺ �Ԫԡ, ���� ������¹㹹�����
    {
        Debug.Log("FixedUpdate Running");
    }

    private void LateUpdate() //�зӧҹ��ѧ �Ѿവ����
    {
        Debug.Log("LateUpdate Running");
    }
}
