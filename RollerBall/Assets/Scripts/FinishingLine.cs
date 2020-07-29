using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.Events;

public class FinishingLine : MonoBehaviour
{
	public float StayTimeForWin = 1f;
	public float timer = 0f;

	private void OnTriggerEnter(Collider other) => IncreaseTimer();

	private void OnTriggerStay(Collider other) => IncreaseTimer();

	private void OnTriggerExit(Collider other) 
	{
		if (!GameManager.I.GetLevelState())
			ResetTimer();
	}


	void IncreaseTimer()
	{
		if (timer < StayTimeForWin)
			timer += Time.deltaTime;

		if (timer >= StayTimeForWin && !GameManager.I.GetLevelState())
			GameManager.I.LevelFinish();
	}
	void ResetTimer() => timer = 0;
}