using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEff : MonoBehaviour
{
    public GameObject hitEffect;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision other)
    {
        Instantiate(hitEffect, other.GetContact(0).point, Quaternion.identity);
    }
}
