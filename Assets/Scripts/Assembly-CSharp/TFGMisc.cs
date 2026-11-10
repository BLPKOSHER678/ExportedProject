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
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static Timer NewTimer()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static Timer StartTimer(string name)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		public static float GetTime(string name)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
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
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static bool checkTouchDown(RelativeRegion region)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static bool checkClickDown(RelativeRegion region)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static bool checkTouch(RelativeRegion region)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static bool checkClick(RelativeRegion region)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static float normalRandomRange(float min, float max)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static bool PointInPolygon(Vector2 point, Vector2[] vertices)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static bool CheckIntersection(Vector2 lineApoint1, Vector2 lineApoint2, Vector2 lineBpoint1, Vector2 lineBpoint2)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static ArrayList MergeSort(ArrayList arrIntegers)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public static float[] MergeSort(float[] list)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
