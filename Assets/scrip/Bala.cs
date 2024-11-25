using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootDeBala : MonoBehaviour
{
    public GameObject ProyectilePrefab;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ProyectilePrefab, transform.position, Quaternion.identity);
        }
    }
}

