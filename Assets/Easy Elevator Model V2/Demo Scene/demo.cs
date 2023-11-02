using UnityEngine;
using System.Collections;

public class demo : MonoBehaviour {
	public	Transform	elevator;
	public	Transform	hallFrame;
	public	Transform	elevator_red;
	public	Transform	hallFrame_red;
	
	void Update () {
		if( Input.GetKeyDown( KeyCode.E ) ){
			OpenDoors();
		}
		
		if( Input.GetKeyDown( KeyCode.R ) ){
			CloseDoors();
		}
	}
	public void OpenDoors()
	{
		var anim = elevator.GetComponent<Animation>().GetClip("OpenDoors");

		elevator.GetComponent<Animation>().clip = anim;
		hallFrame.GetComponent<Animation>().clip = anim;
		elevator.GetComponent<Animation>().Play();
		hallFrame.GetComponent<Animation>().Play();

		elevator_red.GetComponent<Animation>().clip = anim;
		hallFrame_red.GetComponent<Animation>().clip = anim;
		elevator_red.GetComponent<Animation>().Play();
		hallFrame_red.GetComponent<Animation>().Play();
	}
	public void CloseDoors()
	{
		var anim = elevator.GetComponent<Animation>().GetClip("CloseDoors");

		elevator.GetComponent<Animation>().clip = anim;
		hallFrame.GetComponent<Animation>().clip = anim;
		elevator.GetComponent<Animation>().Play();
		hallFrame.GetComponent<Animation>().Play();

		elevator_red.GetComponent<Animation>().clip = anim;
		hallFrame_red.GetComponent<Animation>().clip = anim;
		elevator_red.GetComponent<Animation>().Play();
		hallFrame_red.GetComponent<Animation>().Play();
	}
}
