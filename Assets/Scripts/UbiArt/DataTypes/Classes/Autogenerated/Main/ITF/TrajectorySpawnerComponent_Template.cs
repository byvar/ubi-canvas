using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class TrajectorySpawnerComponent_Template : CSerializable {
		public Placeholder spawneePaths;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			spawneePaths = s.SerializeObject<Placeholder>(spawneePaths, name: "spawneePaths");
		}
		public override uint? ClassCRC => 0x01F2EC37;
	}
}

