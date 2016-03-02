using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {


    public GameObject fireball;
	void Start () {
        fireball.SetActive(false);
	}
	
	
	void Update () {
	
	}

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag=="Player")
        {
            //Instantiate(fireball);
            fireball.SetActive(true);
        }
       
    }
}
