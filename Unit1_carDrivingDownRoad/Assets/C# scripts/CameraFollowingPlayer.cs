using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowingPlayer : MonoBehaviour
{
    // public this to let us see it in unity
    // we will set player == tank
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // void LateUpdate() is where it would make the tank run smoother, meaning the tank's script is Update... the camera's LateUpdate comes after the tank's update
    void LateUpdate() // void Update() == this is where you constantly keep track of smth
    {
        // Offset the camera behind the player by adding to the player's position
        //this is transforming our current camera position to our player's position which we will set in unity as our tank
        // new Vector3(0, 5, -7) is the position of our camera that is following behind our tank
        transform.position = player.transform.position + offset;
    }
}
