using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PhysBodyComponent_Template : CSerializable {
		[Serialize("physShape")] public Placeholder physShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(physShape));
		}
		public override uint? ClassCRC => 0xFF59805E;
	}
}

