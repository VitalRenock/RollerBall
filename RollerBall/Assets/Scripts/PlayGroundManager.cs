using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

[RequireComponent(typeof(TransformProcessor))]
public class PlayGroundManager : Singleton<PlayGroundManager>
{
	public float GroundRotateSpeed = 10f;
	public bool InvertMouseAxis = false;

	public TransformProcessor transformProcessor;


	private void Start()
	{
		transformProcessor = GetComponent<TransformProcessor>();

		if (InvertMouseAxis)
			GroundRotateSpeed = -GroundRotateSpeed;	
	}

	public void CallMouseXCommands(float input)
	{
		float finalSpeed = GroundRotateSpeed * input * Time.deltaTime;
		CommandTransformRotate command = new CommandTransformRotate(transform, Axis.Z, finalSpeed, Space.World);
		transformProcessor.ExecuteCommand(command);

	}
	public void CallMouseYCommands(float input)
	{
		float finalSpeed = GroundRotateSpeed * input * Time.deltaTime;
		CommandTransformRotate command = new CommandTransformRotate(transform, Axis.X, finalSpeed, Space.World);
		transformProcessor.ExecuteCommand(command);

	}
}