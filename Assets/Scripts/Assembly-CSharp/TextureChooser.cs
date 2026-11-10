using System;
using UnityEngine;

[ExecuteInEditMode]
public class TextureChooser : MonoBehaviour
{
	[Serializable]
	public class Element
	{
		public Material material;

		public string[] texturePaths;
	}

	[Serializable]
	public class ElementPrefab
	{
		public Transform target;

		public string[] prefabPaths;
	}

	public bool clear;

	public Element[] elements;

	public ElementPrefab[] elementPrefabs;

	private void Awake()
	{
	}
}
