using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField, Min(0)]
    private float _speed = 1;
    private float _xMove;
    private float _yMove;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _xMove = Input.GetAxis("Horizontal");
        _yMove = Input.GetAxis("Vertical");
        if (_xMove != 0 || _yMove != 0)
        {
            var transition = new Vector2(transform.position.x + _xMove * _speed, transform.position.y + _yMove * _speed);
            transform.position = transition;
        }
    }
}
