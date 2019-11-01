using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    private Vector3 m_mouseDownPosition;
    private Vector3 m_mouseUpPosition;
    [SerializeField]
    private GameObject m_player;
    [SerializeField]
    private float m_force;
    private Rigidbody2D m_playerRB;

	// Use this for initialization
	void Start () {
        m_playerRB = m_player.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            m_mouseDownPosition = Input.mousePosition;
        }
        if(Input.GetMouseButtonUp(0))
        {
            m_mouseUpPosition = Input.mousePosition;
            Vector3 vec = (m_mouseUpPosition - m_mouseDownPosition).normalized;
            Vector2 vforce = new Vector2((m_force * vec).x, (m_force * vec).y);
            m_playerRB.AddForce(vforce*100);
        }
    }
}
