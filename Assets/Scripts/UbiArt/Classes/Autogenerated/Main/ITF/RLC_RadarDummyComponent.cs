using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_RadarDummyComponent : ActorComponent {
		public uint dummyIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			dummyIndex = s.Serialize<uint>(dummyIndex, name: "dummyIndex");
		}
		public override uint? ClassCRC => 0x54851DAA;
	}
}

