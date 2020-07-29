using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
	public Rigidbody Rigidbody;

	private void Awake() => Rigidbody = GetComponent<Rigidbody>();
}