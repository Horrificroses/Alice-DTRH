using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTankController : MonoBehaviour
{

    [SerializeField] private float _moveSpeed = 3f;

    [SerializeField] private float _turnSpeed = 30f;

    private CharacterController _cc;

    // Start is called before the first frame update
    private void Awake()
    {
        _cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _cc.Move(transform.forward * _moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            _cc.Move(-transform.forward * _moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -_turnSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, _turnSpeed * Time.deltaTime, 0);
        }
        
    }
}
