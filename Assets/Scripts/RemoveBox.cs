using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBox : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 3.0f);
    }
}
