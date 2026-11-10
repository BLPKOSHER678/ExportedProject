using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CFX_Demo : MonoBehaviour
{
	public bool orderedSpawns;

	public float step;

	public float range;

	private float order;

	public Material groundMat;

	public Material waterMat;

	public GameObject[] ParticleExamples;

	private Dictionary<string, float> ParticlesYOffsetD;

	private int exampleIndex;

	private string randomSpawnsDelay;

	private bool randomSpawns;

	private bool slowMo;

	private void OnMouseDown()
	{
	}

	private GameObject spawnParticle()
	{
		return default;
	}

	private void OnGUI()
	{
	}

	[DebuggerHidden]
	private IEnumerator RandomSpawnsCoroutine()
	{
		return default;
	}

	private void Update()
	{
	}

	private void prevParticle()
	{
	}

	private void nextParticle()
	{
	}
}
