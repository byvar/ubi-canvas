using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.VH)]
	public partial class AIAction_Template : CSerializable {
		[Serialize("action"               )] public StringID action;
		[Serialize("endMarker"            )] public StringID endMarker;
		[Serialize("useRootPos"           )] public bool useRootPos;
		[Serialize("finishOnContact"      )] public bool finishOnContact;
		[Serialize("rootPosScale"         )] public Vector2 rootPosScale;
		[Serialize("ignoreContactDuration")] public float ignoreContactDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(action));
			SerializeField(s, nameof(endMarker));
			SerializeField(s, nameof(useRootPos));
			SerializeField(s, nameof(finishOnContact));
			SerializeField(s, nameof(rootPosScale));
			SerializeField(s, nameof(ignoreContactDuration));
		}
		public override uint? ClassCRC => 0xA6F57F72;
	}
}

