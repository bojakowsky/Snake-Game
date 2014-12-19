using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
public class GlobalSpeedSetter : MonoBehaviour {

    public float speed ;
    public Text text;
	void Start () 
    {
        DontDestroyOnLoad(this);
	}
	
	public void VolumeSlider(float value)
    {
        string buf = value.ToString();
        text.text = value.ToString();
        speed = Convert.ToInt32(buf);
    }
}
