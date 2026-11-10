using System.Collections;
using System.Diagnostics;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class CFX_AutoDestructShuriken : MonoBehaviour
{
	public bool OnlyDeactivate;

	private void OnEnable()
	{
	}

	[DebuggerHidden]
	private IEnumerator CheckIfAlive()
	{
		return default;
	}
}
