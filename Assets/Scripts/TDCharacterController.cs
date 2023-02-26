using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class TDCharacterController : MonoBehaviour
{
	public float speed;
	public SpriteFacing spriteFacing;

	private Rigidbody2D _rb;
	private Vector2 _moveDirection;
	private Vector2 _lookDirection;

	private void Start () {
		_rb = GetComponent<Rigidbody2D>();
		_rb.bodyType = RigidbodyType2D.Kinematic;
		_rb.constraints = RigidbodyConstraints2D.FreezeRotation;
	}

	private void Update () {
		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");
		_moveDirection = new Vector2(h, v);

		_lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
	}

	private void FixedUpdate () {
		_rb.velocity = _moveDirection * speed;

		Vector2 facing = new();
		switch (spriteFacing) {
			case SpriteFacing.UP: facing = Vector2.up; break;
			case SpriteFacing.DOWN: facing = Vector2.down; break;
			case SpriteFacing.LEFT: facing = Vector2.left; break;
			case SpriteFacing.RIGHT: facing = Vector2.right; break;
		}
		float angle = Vector2.SignedAngle(facing, _lookDirection);
		transform.eulerAngles = new Vector3(0f, 0f, angle);
	}
}

public enum SpriteFacing : byte {
	UP,
	DOWN,
	LEFT,
	RIGHT
}
