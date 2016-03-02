using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour
{
    [SerializeField]
    GameObject shield;
    // Use this for initialization
    void Start()
    {
        shield.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision foo)
    {
        if (foo.gameObject.tag == "Shield")
        {
            Destroy(foo.gameObject);
            shield.SetActive(true);
        }
    }
}
