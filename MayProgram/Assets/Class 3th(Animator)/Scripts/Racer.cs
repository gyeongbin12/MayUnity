using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class Racer : MonoBehaviour
{
    public int [] data;

    private void Start()
    {
        foreach(int element in data)
        {
            Debug.Log(element);
        }
    }
}
