using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTActionFollowCurve_Template : CSerializable {
		[Serialize("name"            )] public StringID name;
		[Description("Anim used when moving along the curve")]
		[Serialize("animMove"        )] public StringID animMove;
		[Description("Anim used when not moving")]
		[Serialize("animIdle"        )] public StringID animIdle;
		[Description("Speed when moving along curve")]
		[Serialize("moveSpeed"       )] public float moveSpeed;
		[Description("Duration of the idle")]
		[Serialize("idleDuration"    )] public float idleDuration;
		[Serialize("followCurveAngle")] public bool followCurveAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(animMove));
			SerializeField(s, nameof(animIdle));
			SerializeField(s, nameof(moveSpeed));
			SerializeField(s, nameof(idleDuration));
			SerializeField(s, nameof(followCurveAngle), boolAsByte: true);
		}
		public override uint? ClassCRC => 0x71C7E752;
	}
}

