using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_SkullCoinComponent : GraphicComponent {
		[Serialize("isTaken")] public bool isTaken;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(isTaken));
			}
		}
		public override uint? ClassCRC => 0x56F2D5DC;
	}
}

