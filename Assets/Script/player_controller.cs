/* Brandon Riley
 * 2/8/2018
 * Moves your player, collects pick ups, adds your score and checks if you win
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_controller : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		winText.text = "";
		
	}
	// Moves player
	void FixedUpdate ()
		{	
			float move_horizontal = Input.GetAxis ("Horizontal");
			float move_vertical = Input.GetAxis ("Vertical");

			Vector3 movement = new Vector3 (move_horizontal, 0.0f, move_vertical);

		rb.AddForce (movement * speed);
		}
		// Checks if you run into a pick up and makes it disapear, adds up score
		void OnTriggerEnter(Collider other) 
		{
		if (other.gameObject.CompareTag("Pick Up"))
			{
			other.gameObject.SetActive(false); //Makes pick up disapear 
			count += 1; 
			SetCountText ();
			}
			if (other.gameObject.CompareTag("Special Pick Up"))
			{
				other.gameObject.SetActive(false); //Makes pick up disapear
				count += 3; 
				SetCountText ();
			}
			if (other.gameObject.CompareTag("Game Over Pick Up"))
			{
				other.gameObject.SetActive(false);//Makes pick up disapear
				count += 10; 
				SetCountText ();
			}
		}
	// Checks to see if you won, and if so prints you win text
	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 26) {
			winText.text = "You Win!";
		}
	}
	}