﻿using UnityEngine;
using System.Collections;

public class BackgroundColliderScript : MonoBehaviour {

    public GameObject ToTransformPosition;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Tigger enter");
        if (other.tag == "BackgroundHelperObject")
        {
            this.gameObject.transform.position = ToTransformPosition.transform.position;
        }
    }
}
