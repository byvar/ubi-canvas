using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_TurnipComponent : RO2_AIComponent {
		public Path actorSpawnedPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			actorSpawnedPath = s.SerializeObject<Path>(actorSpawnedPath, name: "actorSpawnedPath");
		}
		public override uint? ClassCRC => 0x1EBE455E;
	}
}

