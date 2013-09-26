using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class RandomSpin : MonoBehaviour
{
	[HideInInspector] public float minAngularVelocity;
	[HideInInspector] public float maxAngularVelocity;
	
	private Vector3 randomAngularVelocity;
	
	private void Start()
	{
		float minAdjusted = minAngularVelocity;
		
		if(minAdjusted < 0) minAdjusted = 0;
		
		this.randomAngularVelocity.x = Random.Range(this.minAngularVelocity, this.maxAngularVelocity);
		this.randomAngularVelocity.y = Random.Range(this.minAngularVelocity, this.maxAngularVelocity);
		this.randomAngularVelocity.z = Random.Range(this.minAngularVelocity, this.maxAngularVelocity);
		
		if(Random.value < 0.5f) this.randomAngularVelocity.x *= -1;
		if(Random.value < 0.5f) this.randomAngularVelocity.y *= -1;
		if(Random.value < 0.5f) this.randomAngularVelocity.z *= -1;
		
		this.rigidbody.angularVelocity = this.randomAngularVelocity;
	}
	
	public void Pause()
	{
		this.rigidbody.angularVelocity = Vector3.zero;
	}
	
	public void Resume()
	{
		this.rigidbody.angularVelocity = this.randomAngularVelocity;
	}
}
