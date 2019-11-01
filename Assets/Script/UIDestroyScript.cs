using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDestroyScript : MonoBehaviour {

    public float timer = 3.0f;
    void Start()
    {
        Destroy(gameObject, timer);
    }
}
