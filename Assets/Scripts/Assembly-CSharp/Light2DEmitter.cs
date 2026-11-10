using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
public class Light2DEmitter : MonoBehaviour
{
	public enum Light2DType
	{
		Radial = 0,
		Directional = 1
	}

	public enum UVMapping
	{
		Planer = 0,
		Radial = 1
	}

	public static bool PreviewAll;

	public bool PreviewThis;

	public bool isStatic;

	public bool enableEvents;

	public List<Light2DRenderer> assignedRenderers;

	public Light2DType lightType;

	public int lightDetail;

	public float lightSize;

	public float coneAngle;

	public Material lightMaterial;

	public Color lightColor;

	public UVMapping uvMapping;

	public float uvVariable;

	public LayerMask shadowMask;

	public string eventPassedFilter;

	private Light2DMesh mesh;

	private RaycastHit rh;

	private Vector3[] v3;

	private Vector2[] v2;

	private List<GameObject> detectorList;

	private List<GameObject> detectedList;

	private List<GameObject> stayList;

	private static Light2DEvent m_OnBeamStay;

	private static Light2DEvent m_OnBeamEnter;

	private static Light2DEvent m_OnBeamExit;

	public static event Light2DEvent OnBeamStay
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
		}
	}

	public static event Light2DEvent OnBeamEnter
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
		}
	}

	public static event Light2DEvent OnBeamExit
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
		}
	}

	private void OnDrawGizmosSelected()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void DrawGizmoArrow(Vector3 pos, Transform direction)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void GenerateDirectionalMesh()
	{
	}

	private void GenerateRadialMesh()
	{
	}

	private void RegenerateMesh()
	{
	}

	private Vector3[] TransformTriangle(Vector3[] triangles, Transform trans)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private Vector2[] RadialMap(Vector3[] verts, float rotation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private Vector2[] PlanerMap(Vector3[] verts, float rotation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	private void CheckSafeValue()
	{
	}
}
