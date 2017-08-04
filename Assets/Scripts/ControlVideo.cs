using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenderHeads.Media.AVProVideo;
using UnityEngine.UI;

public class ControlVideo : MonoBehaviour {

	public MediaPlayer  media;
	public Slider slider;


	public void PLAY(){
		media.Play ();
	}
	public void PAUSE(){
		media.Pause ();
	}
	public void RESTART(){
		media.Control.Rewind();
		slider.value = 0;
	}
	public void TRANSACTION(float time){
		Debug.Log (slider.value);
		media.Control.Seek(slider.value*time);

	}
	void Update () {
		if (slider.value >= 10) {
			slider.value = 0;
		}
	}
}
