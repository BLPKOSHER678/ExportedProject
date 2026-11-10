using System;
using System.Collections;
using System.Collections.Generic;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class DragRigidbody : MonoBehaviour
{
	[Serializable]
	internal sealed class _0024DragObject_00243 : GenericGenerator<object>
	{
		[Serializable]
		internal sealed class _0024 : GenericGeneratorEnumerator<object>, IEnumerator
		{
			internal float _0024oldDrag_00244;

			internal float _0024oldAngularDrag_00245;

			internal Camera _0024mainCamera_00246;

			internal Ray _0024ray_00247;

			internal float _0024distance_00248;

			internal DragRigidbody _0024self__00249;

			public _0024(float distance, DragRigidbody self_)
			{
			}

			public override bool MoveNext()
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		internal float _0024distance_002410;

		internal DragRigidbody _0024self__002411;

		public _0024DragObject_00243(float distance, DragRigidbody self_)
		{
		}

		public override IEnumerator<object> GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public float spring;

	public float damper;

	public float drag;

	public float angularDrag;

	public float distance;

	public bool attachToCenterOfMass;

	private SpringJoint springJoint;

	public virtual void Update()
	{
	}

	public virtual IEnumerator DragObject(float distance)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public virtual Camera FindCamera()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	public virtual void Main()
	{
	}
}
