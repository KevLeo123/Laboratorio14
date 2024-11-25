using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float velocidadX = 5f;
    public float velocidadY = 5f;
    private Transform _componentTransform;

    private float movimientoHorizontal;
    private float movimientoVertical;

    void Awake()
    {
        _componentTransform = GetComponent<Transform>();
    }

    void Update()
    {
        movimientoHorizontal = Input.GetAxis("Horizontal");
        movimientoVertical = Input.GetAxis("Vertical");

        Vector2 nuevaPosicion = new Vector2(_componentTransform.position.x + movimientoHorizontal * velocidadX * Time.deltaTime, _componentTransform.position.y + movimientoVertical * velocidadY * Time.deltaTime);

        _componentTransform.position = nuevaPosicion;

        LimitarPosicion();
    }

    private void LimitarPosicion()
    {
        float limiteX = 10f;
        float limiteY = 4.3f;

        if (_componentTransform.position.x > limiteX)
        {
            _componentTransform.position = new Vector2(limiteX, _componentTransform.position.y);
        }
        else if (_componentTransform.position.x < -limiteX)
        {
            _componentTransform.position = new Vector2(-limiteX, _componentTransform.position.y);
        }

        if (_componentTransform.position.y > limiteY)
        {
            _componentTransform.position = new Vector2(_componentTransform.position.x, limiteY);
        }
        else if (_componentTransform.position.y < -limiteY)
        {
            _componentTransform.position = new Vector2(_componentTransform.position.x, -limiteY);
        }
    }
}