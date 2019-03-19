using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BubbleSpawnerComponent_Template : CSerializable {
		[Serialize("bubblePath")] public Path bubblePath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bubblePath));
		}
		public override uint? ClassCRC => 0xB3E59BA3;
	}
}

