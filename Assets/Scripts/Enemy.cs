using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float _speed;

    GamManager _gamemanager;

    // Start is called before the first frame update
    void Start()
    {
        _gamemanager = GameObject.Find("Game Manager").GetComponent<GamManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * _speed);
        if(transform.position.z < -2)
        {
            _gamemanager.Score++;
            Destroy(this.gameObject);
        }
    }
}
