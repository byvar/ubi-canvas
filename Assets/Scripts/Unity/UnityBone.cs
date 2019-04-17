using UnityEngine;
using UbiArt;
using UbiArt.ITF;

public class UnityBone : MonoBehaviour {
	/*public Transform parent;
	public Vector3 bindPosition;
	public Quaternion bindRotation;
	public Vector3 localPosition;
	public Quaternion localRotation;

	void Update() {
		if (parent != null) {
			transform.localPosition = parent.transform.localPosition + parent.transform.localRotation * (bindPosition + localPosition); // (Vector3.Scale(parent.transform.localScale, localPosition));
			transform.localRotation = parent.transform.localRotation * (bindRotation * localRotation);
		} else {
			transform.localPosition = bindPosition + localPosition;
			transform.localRotation = bindRotation * localRotation;
		}
	}*/

	/*public Transform parent;
	public Vector3 localPosition;
	public Quaternion localRotation;

	void Update() {
		if (parent != null) {
			transform.localPosition = parent.transform.localPosition + parent.transform.localRotation * (Vector3.Scale(parent.transform.localScale, localPosition));
			transform.localRotation = parent.transform.localRotation * localRotation;
		} else {
			transform.localPosition = localPosition;
			transform.localRotation = localRotation;
		}
	}*/

	public UnityBone parent;
	public Vector3 localPosition;
	public float localRotation;
	public Vector3 localScale;
	public Vector3 bindPosition;
	public float bindRotation;
	public Vector3 bindScale;
	public bool bind = false;
	private Vector3 parentScale = Vector3.one;
	private float cos = 0f;
	private float sin = 0f;
	public Vector3 globalPosition = Vector3.zero;
	public float globalAngle;
	public float xOffset = 0f;

	/*void Update() {
		if (parent != null) {
			transform.localPosition = parent.transform.localPosition + parent.transform.localRotation * (Vector3.Scale(parent.transform.localScale, localPosition));
			transform.localRotation = parent.transform.localRotation * localRotation;
			transform.localScale = Vector3.Scale(parent.transform.localScale, localScale);
		} else {
			transform.localPosition = localPosition;
			transform.localRotation = localRotation;
			transform.localScale = localScale;
		}
	}*/
	void Update() {
		UpdateBone();
	}

	public void UpdateBone() {
		if (bind) {
			if (parent != null) {
				globalAngle = parent.globalAngle + bindRotation + localRotation;
				float xPos = (parent.bindScale.x * parent.localScale.x) * (bindPosition.x + localPosition.x + parent.xOffset);
				float yPos = (parent.bindScale.y * parent.localScale.y) * (bindPosition.y + localPosition.y);
				float dot1 = Vector2.Dot(new Vector2(xPos, yPos), new Vector2(parent.cos, parent.sin));
				float dot2 = Vector2.Dot(new Vector2(yPos, Mathf.Abs(xPos)), new Vector2(parent.cos, parent.sin));
				globalPosition = parent.globalPosition + new Vector3(dot1, dot2, 0f);
			} else {
				globalPosition = bindPosition + localPosition;
				globalAngle = bindRotation + localRotation;
			}
			transform.localScale = Vector3.Scale(localScale, bindScale);
			transform.localRotation = new Angle(globalAngle).QuaternionAngle;
			transform.localPosition = globalPosition;
			cos = Mathf.Cos(globalAngle);
			sin = Mathf.Sin(globalAngle);
		} else {
			if (parent != null) {
				transform.localPosition = parent.transform.localPosition + parent.transform.localRotation * localPosition;
				transform.localRotation = parent.transform.localRotation * new Angle(localRotation).QuaternionAngle;
				transform.localScale = localScale;
			} else {
				transform.localPosition = localPosition;
				transform.localRotation = new Angle(localRotation).QuaternionAngle;
				transform.localScale = localScale;
			}
		}
		/*if (bind) {
			// 1. scale
			// 2. rotation
			// 3. position
			if (parent != null) {
				parentScale = Vector3.Scale(parent.parentScale, parent.transform.localRotation * Vector3.Scale(parent.localScale, parent.bindScale));
				transform.localScale = Vector3.Scale(localScale, bindScale);

				transform.localRotation = parent.transform.localRotation * new Angle(bindRotation + localRotation).QuaternionAngle;
				transform.localPosition = parent.transform.localPosition + Vector3.Scale(transform.localScale, Vector3.Scale(parentScale, transform.localRotation * (bindPosition + localPosition)));
			} else {
				transform.localScale = Vector3.Scale(localScale, bindScale);
				transform.localRotation = new Angle(bindRotation + localRotation).QuaternionAngle;
				transform.localPosition = Vector3.Scale(transform.localScale, (bindPosition + localPosition));
			}
		} else {
			if (parent != null) {
				transform.localPosition = parent.transform.localPosition + parent.transform.localRotation * localPosition;
				transform.localRotation = parent.transform.localRotation * new Angle(localRotation).QuaternionAngle;
				transform.localScale = localScale;
			} else {
				transform.localPosition = localPosition;
				transform.localRotation = new Angle(localRotation).QuaternionAngle;
				transform.localScale = localScale;
			}
		}*/

		/*Compute Global

xPos = this.xPos
xPos += p.2ndfloat_thing
xPos *= p.xScale
yPos = this.yPos * p.yScale

dot1 = vec2d.Dot(Vec2d(xPos, yPos), Vec2d(p.cos,p.sin));
dot2 = vec2d.Dot(Vec2d(ypos, -xPos), Vec2d(p.cos,p.sin));

this.vec0 = p.vec0 + new Vec2d(dot1,dot2);
this.angle = parent.angle + angle;
this.cos = cos(this.angle);
this.sin = sin(this.angle);


Compute End
xPos = this.2ndfloatthing * this.xScale
dot1 =  vec2d.Dot(Vec2d(xPos, 0), Vec2d(this.cos,this.sin));
dot2 =  vec2d.Dot(Vec2d(0, -xPos), Vec2d(this.cos,this.sin));
this+0x8 = this.pos + new Vec2d(dot1,dot2);
*/
	}
}
