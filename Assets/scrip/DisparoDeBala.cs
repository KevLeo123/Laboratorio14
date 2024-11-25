using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoDeBala : MonoBehaviour
{
    public float VelocidadDeDisparo;
    public GameObject explosioPrefab;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector2.up * VelocidadDeDisparo * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Instantiate(explosioPrefab, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}