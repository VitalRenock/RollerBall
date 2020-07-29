using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingLine : MonoBehaviour
{
	public Ball SpawnBall(GameObject ballPrefab)
	{
		GameObject gameObject = Instantiate(ballPrefab.gameObject, transform.position, Quaternion.identity, PlayGroundManager.I.transform);
		return gameObject.GetComponent<Ball>();
	}
}