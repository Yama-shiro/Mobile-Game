using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //publics
    [Header("Lerp")]
    public Transform target;
    public float lerpSpeed = 1f;

    public float speed = 1f;

    public string tagToCheckEnemy = "Enemy";

    //privates
    private bool _canRun;
    private Vector3 _pos;


    private void start()
    {
        _canRun = true;
    }

    void Update()
    {
        if(!_canRun) return;


        var pos = target.position;
        pos.y = transform.position.y;
        pos.z = transform.position.z;

        transform.position = Vector3.Lerp(transform.position, target.position, lerpSpeed * Time.deltaTime);
        transform.Translate(transform.forward * speed *Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == tagToCheckEnemy)
        {
            _canRun = false;
        }
    }
}
