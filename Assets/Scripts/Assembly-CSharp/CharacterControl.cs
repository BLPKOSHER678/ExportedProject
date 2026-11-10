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

    private Rigidbody body;
    private float jumpCooldown;
    private const float DefaultHorizontalJump = 11f;
    private const float DefaultVerticalJump = 9f;

    private void OnCollisionStay(Collision collisionInfo) { UpdateContact(collisionInfo); }

    private void UpdateContact(Collision collisionInfo)
    {
        foreach (ContactPoint contact in collisionInfo.contacts)
        {
            if (contact.normal.y > 0.45f)
            {
                pseudoGround = true;
                timerLateGround = lateGroundTime;
                airJumpCount = Mathf.Max(0, airJumps);
                jumping = false;
            }
            if (Mathf.Abs(contact.normal.x) > 0.45f) wallHitNormal = contact.normal;
        }
    }

	public float groundSoundCoolDown;

	public bool walling
	{
		get
		{
			return wallingLeft || wallingRight;
		}
	}

	public bool wallingLeft
	{
		get
		{
			return wallHitNormal.x > 0.5f && collisionCount > 0;
		}
	}

	public bool wallingRight
	{
		get
		{
			return wallHitNormal.x < -0.5f && collisionCount > 0;
		}
	}

	public bool snapping
	{
		get
		{
			return currentSnap > 0f;
		}
	}

	public bool grounded
	{
		get
		{
			return pseudoGround || timerLateGround > 0f;
		}
	}

	public bool collided
	{
		get
		{
			return collisionCount > 0;
		}
	}

	private void Awake()
	{
        body = GetComponent<Rigidbody>();
        if (body == null) body = gameObject.AddComponent<Rigidbody>();
        body.constraints |= RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;
        if (gameControl == null) gameControl = FindObjectOfType<GameControl>();
        // The original gameplay videos show the jelly waiting until a tap: NO automatic forward movement.
        if (Mathf.Abs(jumpForce.x) < 0.1f) jumpForce.x = DefaultHorizontalJump;
        if (jumpForce.y <= 0f) jumpForce.y = DefaultVerticalJump;
        if (jumpingDuration <= 0f) jumpingDuration = 0.22f;
        if (lateGroundTime <= 0f) lateGroundTime = 0.10f;
        if (dieHeight == 0f) dieHeight = -40f;
        body.drag = 0f;
        airJumpCount = Mathf.Max(0, airJumps);
	}

	private void FixedUpdate()
	{
        if (finished || body == null || (gameControl != null && gameControl.paused)) return;
        Vector3 velocity = body.velocity;
        // Ground friction stops the jelly at each platform, as seen in the original recordings.
        // Airborne velocity is preserved between jumps, rather than applying automatic running.
        if (grounded && !jumping)
        {
            float braking = groundAdjustSpeed > 0.1f ? groundAdjustSpeed * 3f : 30f;
            velocity.x = Mathf.MoveTowards(velocity.x, 0f, braking * Time.fixedDeltaTime);
        }
        if (jumping && jumpingDurVal > 0f && (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space)))
        {
            // Holding extends the ascending part of a jump; releasing cuts it short.
            body.AddForce(Vector3.up * Mathf.Max(3f, jumpForce.y * 2f), ForceMode.Acceleration);
            jumpingDurVal -= Time.fixedDeltaTime;
        }
        else if (jumping)
        {
            jumping = false;
        }
        body.velocity = velocity;
	}

	private void Update()
	{
        if (finished || body == null) return;
        timerLateGround = Mathf.Max(0f, timerLateGround - Time.deltaTime);
        jumpCooldown = Mathf.Max(0f, jumpCooldown - Time.deltaTime);
        bool pressed = Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space);
        if (pressed && !(gameControl != null && gameControl.paused)) Jump();
        if (Input.GetMouseButtonUp(0) || Input.GetKeyUp(KeyCode.Space)) jumping = false;
        if (body.position.y < dieHeight && gameControl != null && !gameControl.isPlayerDied())
            gameControl.playerDied(GameControl.DeathType.HEIGHT);
	}

	public void reset()
	{
        finished = false;
        jumping = false;
        pseudoGround = false;
        collisionCount = 0;
        timerLateGround = 0.15f;
        jumpCooldown = 0f;
        airJumpCount = Mathf.Max(0, airJumps);
        jumpingDurVal = 0f;
        if (body != null) { body.velocity = Vector3.zero; body.angularVelocity = Vector3.zero; }
	}

	public void EndingJump()
	{
        finished = true;
        jumping = false;
        if (body != null) body.velocity = new Vector3(0f, Mathf.Max(endingJumpSpeed, jumpForce.y * 0.6f), 0f);
	}

	public void Jump()
	{
        if (finished || body == null || jumpCooldown > 0f) return;
        // The videos show successive ground jumps and wall jumps, not automatic running.
        bool fromWall = walling;
        if (!grounded && !fromWall)
        {
            if (airJumpCount <= 0) return;
            --airJumpCount;
        }
        pseudoGround = false;
        timerLateGround = 0f;
        jumpCooldown = 0.10f;
        jumping = true;
        jumpingDurVal = jumpingDuration;
        Vector3 velocity = body.velocity;
        float horizontal = Mathf.Abs(jumpForce.x) > 0.1f ? jumpForce.x : DefaultHorizontalJump;
        velocity.x = horizontal;
        velocity.y = Mathf.Max(jumpForce.y, fromWall ? DefaultVerticalJump : 0f);
        body.velocity = velocity;
        if (gameControl != null) gameControl.spendJump();
        if (jumpClip != null) AudioSource.PlayClipAtPoint(jumpClip, transform.position);
	}

	private void OnCollisionEnter(Collision collisionInfo)
	{
        collisionCount++;
        UpdateContact(collisionInfo);
        if (gameControl != null && collisionInfo.collider != null)
        {
            string hitName = collisionInfo.collider.name.ToLowerInvariant();
            // In the recovered levels the goal is a solid BoxCollider (not a trigger).
            if (hitName == "endpoint" || hitName == "portalend") gameControl.getToEndPoint();
            else if (!passEnemies && hitName.Contains("enemy"))
                gameControl.playerDied(GameControl.DeathType.MONSTER);
        }
	}

	private void OnTriggerEnter(Collider other)
	{
        if (other == null || gameControl == null || finished) return;
        string lowerName = other.gameObject.name.ToLowerInvariant();
        if (lowerName.Contains("end") || lowerName.Contains("portalend"))
            gameControl.getToEndPoint();
        else if (lowerName.Contains("heart"))
        {
            gameControl.collectCoin(GameControl.CoinType.HEART);
            other.gameObject.SetActive(false);
        }
        else if (lowerName.Contains("medal") || lowerName.Contains("coin"))
        {
            gameControl.collectCoin(GameControl.CoinType.MEDAL);
            other.gameObject.SetActive(false);
        }
        else if (lowerName.Contains("enemy") && !passEnemies)
            gameControl.playerDied(GameControl.DeathType.MONSTER);
        else if (lowerName.Contains("checkpoint"))
        {
            Checkpoint checkpoint = other.GetComponent<Checkpoint>();
            if (checkpoint != null) gameControl.enableCheckpoint(checkpoint.ID);
        }
	}

	private void OnDisable()
	{
        jumping = false;
        pseudoGround = false;
	}

	private void OnCollisionExit(Collision collisionInfo)
	{
        collisionCount = Mathf.Max(0, collisionCount - 1);
        if (collisionCount == 0) { pseudoGround = false; wallHitNormal = Vector3.zero; }
        timerLateGround = lateGroundTime;
	}

	public void OnDrawGizmos()
	{
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, 0.12f);
	}
}
