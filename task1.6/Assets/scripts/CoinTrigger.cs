using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        Debug.Log("Collected coin");
    }
}
