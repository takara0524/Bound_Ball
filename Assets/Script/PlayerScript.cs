using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    private Rigidbody2D m_RB2D;
	// Use this for initialization
	void Start () {
        m_RB2D = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Mathf.Abs(m_RB2D.velocity.x) < 0.5f)
        {
            m_RB2D.velocity *= new Vector3(0.0f, 1.0f, 1.0f) ;
        }
        m_RB2D.velocity *= new Vector3(0.99f, 1.0f, 1.0f);
    }
}
