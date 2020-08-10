using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour
{
    void Start()
    {
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    void Update()
    {
        this.transform.Rotate(0, 3, 0);
    }
}