using UnityEngine;
using System.Collections;
using System;

public class TestClock : MonoBehaviour
{

	[EditorButton]
	public IEnumerator RunClock(int duration = 3) {
		int n = 0;
		while (n < duration) {
			Debug.Log (n % 2 == 0 ? "Tick" : "Tack");
			yield return new WaitForSeconds (1.0f);
			n++;
		}
	}
}

