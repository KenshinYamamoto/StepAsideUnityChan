using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        if(this.transform.position.z < Camera.main.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
