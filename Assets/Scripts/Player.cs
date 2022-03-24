using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject _gameOverUI;

    private void FixedUpdate()
    {
        if(transform.position.x >= 4)
        {
            transform.position = new Vector3(4, transform.position.y, transform.position.z);
        }

        if (transform.position.x <= -4)
        {
            transform.position = new Vector3(-4, transform.position.y, transform.position.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Time.timeScale = 0;
            _gameOverUI.SetActive(true);
        }
    }
}
