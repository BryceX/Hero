using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
    //Camera playerCam;
    //public string up;
    //public string down;
    //public string left;
    //public string right;
    //float speed = 20;

    public GameObject player;

    private Vector3 offset;
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

   
    void Update () {
	
	}
   

    

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
    //void SetMovementDir(Camera myCam, string key, Vector3 direction, float a_speed)
    //{

    //    if (Input.GetKey(key))
    //    {

    //        //if (speed < maxSpeed)
    //        //{
    //        //    speed += 25 * Time.deltaTime;
    //        //}
    //        //myCam.transform.position += (direction * Time.deltaTime * a_speed);

    //       // myCam.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
    //      Camera.main.transform.position= (direction * Time.deltaTime * a_speed);




    //    };
        
    //}

    //void Movement()
    //{

    //    SetMovementDir(playerCam, up, Vector3.forward, speed);
    //    SetMovementDir(playerCam, down, Vector3.back, speed);
    //    SetMovementDir(playerCam, left, Vector3.left, speed);
    //    SetMovementDir(playerCam, right, Vector3.right, speed);

    //}
}
