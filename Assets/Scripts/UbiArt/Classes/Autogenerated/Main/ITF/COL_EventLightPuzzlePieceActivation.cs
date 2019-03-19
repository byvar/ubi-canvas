using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventLightPuzzlePieceActivation : CSerializable {
		[Serialize("sender"  )] public uint sender;
		[Serialize("Activate")] public int Activate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
			SerializeField(s, nameof(Activate));
		}
		public override uint? ClassCRC => 0xBEE28A91;
	}
}

