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
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
