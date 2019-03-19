using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_SkullCoinComponent : GraphicComponent {
		[Serialize("isTaken")] public int isTaken;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(isTaken));
			}
		}
		public override uint? ClassCRC => 0x56F2D5DC;
	}
}

