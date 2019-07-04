﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltDetect : MonoBehaviour
{

    [SerializeField] GameObject Selector;
    float speed = 0.5f;

    #region Methods

    void Start()
    {
        Selector = GameObject.Find("Selector");
    }

    private void OnCollisionStay(Collider other) {
        
        if(other.gameObject != Selector){
            other.gameObject.transform.position += transform.forward * speed;
        }
    }

    #endregion
}
