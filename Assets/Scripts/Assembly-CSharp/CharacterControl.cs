using UnityEngine;

public class CharacterControl : MonoBehaviour
{
	public Vector2 jumpForce;

	private int collisionCount;

	private bool pseudoGround;

	private bool jumping;

	public float jumpingDuration;

	public float catAdjustSpeed;

	public float groundAdjustSpeed;

	public float jumpCollisionThreshold;

	private float jumpingDurVal;

	private bool _anyKeyDown;

	private bool anyKey;

	private Vector2 jumpDirection;

	private Vector3 meanNormal;

	public float dieHeight;

	public GameControl gameControl;

	private bool left;

	private bool right;

	private bool down;

	private bool oldDown;

	public float snapDuration;

	private float currentSnap;

	private Vector3 wallHitNormal;

	public float lateGroundTime;

	private float timerLateGround;

	private bool lateGrounded;

	public float[] groundFrictions;

	private int groundType;

	private int wallType;

	public float groundFrictionTime;

	private float timerGroundFriction;

	public AudioClip jumpClip;

	public AudioClip groundClip;

	private Rigidbody collidingRigidbody;

	public float jumpReactionForce;

	private bool finished;

	public float endingDelay;

	public float endingRepeat;

	public float endingJumpSpeed;

	private float endingXPos;

	private Vector3 oldPointVelocity;

	public float upJumpThreshold;

	public int airJumps;

	private int airJumpCount;

	public bool passEnemies;

	public bool killEnemies;

	private bool levelStart;

	private float audioCoolDown;

	public float groundSoundCoolDown;

	public bool walling
	{
		get
		{
			return default;
		}
	}

	public bool wallingLeft
	{
		get
		{
			return default;
		}
	}

	public bool wallingRight
	{
		get
		{
			return default;
		}
	}

	public bool snapping
	{
		get
		{
			return default;
		}
	}

	public bool grounded
	{
		get
		{
			return default;
		}
	}

	public bool collided
	{
		get
		{
			return default;
		}
	}

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	public void reset()
	{
	}

	public void EndingJump()
	{
	}

	public void Jump()
	{
	}

	private void OnCollisionEnter(Collision collisionInfo)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnDisable()
	{
	}

	private void OnCollisionExit(Collision collisionInfo)
	{
	}

	public void OnDrawGizmos()
	{
	}
}
