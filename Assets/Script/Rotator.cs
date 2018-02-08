/* Brandon Riley
 * 2/8/2018
 * rotates pick ups
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
	//rotates pick ups
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}
