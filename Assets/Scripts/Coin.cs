using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationSpeed = 90f;


    private void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.AddScore(1);
            Destroy(gameObject);
        }
    }
}
