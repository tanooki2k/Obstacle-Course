// using System.Collections;
// using System.Collections.Generic;

using UnityEngine;

public class Dropper : MonoBehaviour
{
    private MeshRenderer _renderer;
    private Rigidbody _rigidBody;
    [SerializeField] private float timeToWait = 3f;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
        _rigidBody = GetComponent<Rigidbody>();

        _renderer.enabled = false;
        _rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            _renderer.enabled = true;
            _rigidBody.useGravity = true;
        }
    }
}