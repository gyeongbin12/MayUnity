using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class CreateManager : MonoBehaviour
{
    public Factory factory;

    public float x = 2.5f;
    public GameObject unit;

    private void Awake()
    {
        factory = GetComponent<Factory>();
    }

    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            unit = Instantiate(unit);

            unit.transform.position = new Vector3(x, 0, 0);

            x += 2.5f;
        }
    }
}

