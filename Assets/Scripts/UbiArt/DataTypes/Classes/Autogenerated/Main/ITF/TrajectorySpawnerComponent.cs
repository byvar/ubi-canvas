using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class TrajectorySpawnerComponent : CSerializable {
		public Placeholder spawneePaths;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				spawneePaths = s.SerializeObject<Placeholder>(spawneePaths, name: "spawneePaths");
			}
		}
		public override uint? ClassCRC => 0x629061C6;
	}
}

