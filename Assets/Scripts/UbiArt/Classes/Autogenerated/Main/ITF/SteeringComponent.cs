using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class SteeringComponent : ActorComponent {
		[Serialize("drawDebug")] public bool drawDebug;
		[Serialize("WalkSpeed")] public float WalkSpeed;
		[Serialize("RunSpeed" )] public float RunSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(drawDebug));
			SerializeField(s, nameof(WalkSpeed));
			SerializeField(s, nameof(RunSpeed));
		}
		public override uint? ClassCRC => 0x388C5A2B;
	}
}

