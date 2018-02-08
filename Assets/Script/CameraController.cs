/* Brandon Riley
 * 2/8/2018
 * Moves the camera in relation to the player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// moves camera in relation to the player
	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position; //gives you the distance from the player
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset; //moves the player the distance we got from offset
	}
}
