using UnityEngine;
using System.Collections;

public class MyCameraController : MonoBehaviour
{
    private GameObject unitychan;
    private float difference;

    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");
        this.difference = unitychan.transform.position.z - this.transform.position.z;

    }

    void Update()
    {
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag")
        {
            Destroy(other.gameObject);
        }
    }
}