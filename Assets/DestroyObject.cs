﻿using System.Collections;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "MainCamera")
        {
            Destroy(this.gameObject);
        }
    }
}