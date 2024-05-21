using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    void Active();

}

public class EffectZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        IDamageable damageable = other.GetComponent<IDamageable>();

        if (other.CompareTag("Other Cube"))
        {
            Debug.Log("OnTriggerEnter");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Other Cube"))
        {
            Debug.Log("OnTriggerStay");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Other Cube"))
        {
            Debug.Log("OnTriggerExit");
        }
    }
}
