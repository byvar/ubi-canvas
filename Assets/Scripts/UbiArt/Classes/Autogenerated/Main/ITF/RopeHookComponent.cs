using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class RopeHookComponent : ActorComponent {
		[Serialize("touchHandler"             )] public TouchHandler touchHandler;
		[Serialize("torqueFriction"           )] public float torqueFriction;
		[Serialize("attachmentDetectionRadius")] public float attachmentDetectionRadius;
		[Serialize("hookingSmoothFactor"      )] public float hookingSmoothFactor;
		[Serialize("hookOffset"               )] public Vec2d hookOffset;
		[Serialize("angleOffset"              )] public Angle angleOffset;
		[Serialize("angleSmoothingFactor"     )] public float angleSmoothingFactor;
		[Serialize("snapDist"                 )] public float snapDist;
		[Serialize("float__0"                 )] public float float__0;
		[Serialize("float__1"                 )] public float float__1;
		[Serialize("float__2"                 )] public float float__2;
		[Serialize("Vector2__3"               )] public Vec2d Vector2__3;
		[Serialize("Angle__4"                 )] public Angle Angle__4;
		[Serialize("float__5"                 )] public float float__5;
		[Serialize("float__6"                 )] public float float__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(float__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(Vector2__3));
				SerializeField(s, nameof(Angle__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(float__6));
			} else {
				SerializeField(s, nameof(touchHandler));
				SerializeField(s, nameof(torqueFriction));
				SerializeField(s, nameof(attachmentDetectionRadius));
				SerializeField(s, nameof(hookingSmoothFactor));
				SerializeField(s, nameof(hookOffset));
				SerializeField(s, nameof(angleOffset));
				SerializeField(s, nameof(angleSmoothingFactor));
				SerializeField(s, nameof(snapDist));
			}
		}
		public override uint? ClassCRC => 0xB42762E7;
	}
}

