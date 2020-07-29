using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
	[TabGroup("Level")]
	[SerializeField][ReadOnly] bool levelFinish = true;
	[TabGroup("Ball")][AssetsOnly] 
	public GameObject BallPrefab;
	[TabGroup("Ball")][ReadOnly]
	public Ball BallPlayer;
	[TabGroup("StartingLine")]
	public StartingLine StartingLine;


	private void Start() => StartCoroutine(LevelLoop());


	IEnumerator LevelLoop()
	{
		LoadLevel();

		while (!levelFinish)
		{
			yield return null;
		}

		UnloadLevel();
	}


	void LoadLevel()
	{
		Debug.Log("Level start!");
		levelFinish = false;
		BallPlayer = StartingLine.SpawnBall(BallPrefab);
	}
	void UnloadLevel()
	{
		Debug.Log("Level finish!");
	}
	public void LevelFinish()
	{
		BallPlayer.Rigidbody.isKinematic = true;
		levelFinish = true;
	}
	public bool GetLevelState()
	{
		return levelFinish;
	}
}