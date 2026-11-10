using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class CFX_ShurikenThreadFix : MonoBehaviour
{
	private ParticleSystem[] systems;

	private void Awake()
	{
	}

	[DebuggerHidden]
	private IEnumerator WaitFrame()
	{
		return default;
	}
}
