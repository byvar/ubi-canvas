using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class TrajectorySpawnerComponent_Template : CSerializable {
		[Serialize("spawneePaths")] public Placeholder spawneePaths;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(spawneePaths));
		}
		public override uint? ClassCRC => 0x01F2EC37;
	}
}

