using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_CamModeMoverComponent : ActorComponent {
		[Serialize("TimeToMove")] public float TimeToMove;
		[Serialize("BlendCoeff")] public float BlendCoeff;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(TimeToMove));
				SerializeField(s, nameof(BlendCoeff));
			}
		}
		public override uint? ClassCRC => 0xD2957F2A;
	}
}

