using UnityEngine;
using System.Collections;

public class KillCount : MonoBehaviour {
	public static int Count=0;

	void OnGUI() {
		GUILayout.Label ("Space Polar Bears Saved: " + Count.ToString());
	}
    public static void increment()
    {
        ++Count;
    }
}