using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class colorComputerComponent : ActorComponent {
		[Serialize("near"     )] public float near;
		[Serialize("far"      )] public float far;
		[Serialize("nearColor")] public Color nearColor;
		[Serialize("farColor" )] public Color farColor;
		[Serialize("tagId"    )] public uint tagId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(near));
				SerializeField(s, nameof(far));
				SerializeField(s, nameof(nearColor));
				SerializeField(s, nameof(farColor));
				SerializeField(s, nameof(tagId));
			}
		}
		public override uint? ClassCRC => 0xD052E936;
	}
}

