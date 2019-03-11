using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_Mission_Guard_PlayerPoly_CheckOrientation : RLC_Mission_Guard {
		[Serialize("edgeOrientation")] public uint edgeOrientation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(edgeOrientation));
		}
		public override uint? ClassCRC => 0xD7534FEA;
	}
}

