using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle_burst : MonoBehaviour {
	public void burst() {
		ParticleSystem system = gameObject.GetComponent<ParticleSystem>();
		system.Emit(1);
	}

}
