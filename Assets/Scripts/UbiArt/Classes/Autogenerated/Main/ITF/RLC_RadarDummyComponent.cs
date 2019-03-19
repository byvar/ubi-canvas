using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_RadarDummyComponent : ActorComponent {
		[Serialize("dummyIndex")] public uint dummyIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(dummyIndex));
		}
		public override uint? ClassCRC => 0x54851DAA;
	}
}

