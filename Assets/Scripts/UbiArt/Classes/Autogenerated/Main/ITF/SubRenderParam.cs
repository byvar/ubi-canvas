using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class SubRenderParam : CSerializable {
		[Serialize("Enable")] public bool Enable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Enable));
		}
		public override uint? ClassCRC => 0xDE8F531A;
	}
}

