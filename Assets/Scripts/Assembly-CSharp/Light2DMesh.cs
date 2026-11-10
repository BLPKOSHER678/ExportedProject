using System.Collections.Generic;
using UnityEngine;

public class Light2DMesh
{
	public List<Light2DTriangle> triangles;

	public Material material;

	public void SubmitForRender(Light2DRenderer light2DRenderer, Material material)
	{
	}

	public void ForceMeshOffRenderQue(Light2DRenderer light2DRenderer)
	{
	}

	public void AddTriangle(Vector3[] verts, Vector2[] uvs, Color color)
	{
	}

	public void UpdateTriangleUV(int index, Vector2[] uvs, Color color)
	{
	}

	public void Clear()
	{
	}
}
