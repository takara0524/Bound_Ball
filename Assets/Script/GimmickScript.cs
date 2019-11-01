using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickScript : MonoBehaviour {

    [SerializeField]
    private GameObject m_textUI;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            m_textUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
