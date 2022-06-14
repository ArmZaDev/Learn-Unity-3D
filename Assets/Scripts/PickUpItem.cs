using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
 

    private void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.tag == "Item") //tag.Equals("Item")
        {
            //Delete Item in Scene game
            Destroy(target.gameObject);
        }
    }


}
