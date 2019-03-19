using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_365_sub_ACD4A0 : CSerializable {
		[Serialize("orangeMinSpeed"        )] public float orangeMinSpeed;
		[Serialize("orangeMaxSpeed"        )] public float orangeMaxSpeed;
		[Serialize("landingSpeedXThreshold")] public float landingSpeedXThreshold;
		[Serialize("arrivalDistance"       )] public float arrivalDistance;
		[Serialize("moveThreshold"         )] public float moveThreshold;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(orangeMinSpeed));
			SerializeField(s, nameof(orangeMaxSpeed));
			SerializeField(s, nameof(landingSpeedXThreshold));
			SerializeField(s, nameof(arrivalDistance));
			SerializeField(s, nameof(moveThreshold));
		}
		public override uint? ClassCRC => 0xFBA39F47;
	}
}

