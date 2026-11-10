using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TFGMisc : MonoBehaviour
{
	public class Timer
	{
		private float startTime;

		private static Dictionary<string, Timer> timers;

		public void resetStart()
		{
		}

		public float getTime()
		{
			return default;
		}

		public static Timer NewTimer()
		{
			return default;
		}

		public static Timer StartTimer(string name)
		{
			return default;
		}

		public static float GetTime(string name)
		{
			return default;
		}
	}

	[Serializable]
	public class RelativeRegion
	{
		public float minX;

		public float minY;

		public float maxX;

		public float maxY;

		public RelativeRegion()
		{
		}

		public RelativeRegion(Rect rect)
		{
		}

		public bool Contains(Vector2 point)
		{
			return default;
		}
	}

	[Serializable]
	public class Matrix
	{
		public Vector3 r1;

		public Vector3 r2;

		public Vector3 r3;

		public static Vector3 operator *(Matrix a, Vector3 b)
		{
			return default;
		}
	}

	public class Polygon
	{
		private Vector2[] _vertices;

		public Polygon(Vector2[] vertices)
		{
		}

		public bool PointInPolygon(Vector2 point)
		{
			return default;
		}
	}

	public static bool checkTouchDown(RelativeRegion region)
	{
		return default;
	}

	public static bool checkClickDown(RelativeRegion region)
	{
		return default;
	}

	public static bool checkTouch(RelativeRegion region)
	{
		return default;
	}

	public static bool checkClick(RelativeRegion region)
	{
		return default;
	}

	public static float normalRandomRange(float min, float max)
	{
		return default;
	}

	public static bool PointInPolygon(Vector2 point, Vector2[] vertices)
	{
		return default;
	}

	public static bool CheckIntersection(Vector2 lineApoint1, Vector2 lineApoint2, Vector2 lineBpoint1, Vector2 lineBpoint2)
	{
		return default;
	}

	public static ArrayList MergeSort(ArrayList arrIntegers)
	{
		return default;
	}

	public static float[] MergeSort(float[] list)
	{
		return default;
	}
}
