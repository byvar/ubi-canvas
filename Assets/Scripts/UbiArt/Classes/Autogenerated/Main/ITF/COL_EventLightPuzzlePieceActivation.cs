using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventLightPuzzlePieceActivation : Event {
		[Serialize("Activate")] public int Activate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Activate));
		}
		public override uint? ClassCRC => 0xBEE28A91;
	}
}

