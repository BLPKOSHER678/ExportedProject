using System;
using UnityEngine;

[ExecuteInEditMode]
public class GUITransform : MonoBehaviour
{
	[Serializable]
	public class Matrix
	{
		public Vector3 r1;

		public Vector3 r2;

		public Vector3 r3;

		public static Vector3 operator *(Matrix a, Vector3 b)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Vector3 positionAbs;

	public Matrix positionRelMatrix;

	public bool limitMaxPosition;

	public bool limitMinPosition;

	public Vector3 maxPosition;

	public Vector3 minPosition;

	public Vector3 rotationAbs;

	public Matrix rotationRelMatrix;

	public Vector3 scaleAbs;

	public Matrix scaleRelMatrix;

	public bool limitMaxScale;

	public bool limitMinScale;

	public Vector3 maxScale;

	public Vector3 minScale;

	public bool destroyOnPlay;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void apply()
	{
	}
}
