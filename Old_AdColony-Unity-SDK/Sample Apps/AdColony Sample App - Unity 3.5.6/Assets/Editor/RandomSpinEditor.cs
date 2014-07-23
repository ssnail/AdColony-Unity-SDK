using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(RandomSpin))]
public class RandomSpinEditor : Editor
{
	private const float MAX_VALUE = 5.0f;
	
	RandomSpin randomSpin;
	
	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();
		
		this.randomSpin = (RandomSpin)target;
		this.randomSpin.minAngularVelocity = EditorGUILayout.Slider
											(
		 										"Min Angular Velocity:",
		 										this.randomSpin.minAngularVelocity,
		 										0.0f,
		 										RandomSpinEditor.MAX_VALUE - 0.001f
		 									);
		
		this.randomSpin.maxAngularVelocity = EditorGUILayout.Slider
											(
			 									"Max Angular Velocity:",
			 									this.randomSpin.maxAngularVelocity,
			 									this.randomSpin.minAngularVelocity,
			 									RandomSpinEditor.MAX_VALUE
			 								);
		
		if(GUI.changed)
		{
			EditorUtility.SetDirty(target);
		}
	}
}
