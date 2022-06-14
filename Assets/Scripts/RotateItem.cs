using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateItem : MonoBehaviour
{

    public float speed = 100f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime, 0f, 0f);
    }
}
