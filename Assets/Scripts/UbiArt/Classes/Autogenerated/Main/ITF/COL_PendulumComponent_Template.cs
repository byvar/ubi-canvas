using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PendulumComponent_Template : CSerializable {
		[Serialize("fxOnHit"      )] public StringID fxOnHit;
		[Serialize("fxOnStartMove")] public StringID fxOnStartMove;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fxOnHit));
			SerializeField(s, nameof(fxOnStartMove));
		}
		public override uint? ClassCRC => 0x98B83CF2;
	}
}

