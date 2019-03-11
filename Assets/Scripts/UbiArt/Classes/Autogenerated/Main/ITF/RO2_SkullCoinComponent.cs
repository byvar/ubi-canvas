using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SkullCoinComponent : GraphicComponent {
		[Serialize("isTaken")] public bool isTaken;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(isTaken));
			}
		}
		public override uint? ClassCRC => 0x5676E420;
	}
}

