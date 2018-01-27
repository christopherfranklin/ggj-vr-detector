using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorController : MonoBehaviour {

	public GameObject m_pulse;

	private OVRGrabbable m_grabbable;

	// Use this for initialization
	void Start () {
		m_grabbable = GetComponent<OVRGrabbable> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (m_grabbable.isGrabbed) {
			// Send out pulse
		}
	}
}
