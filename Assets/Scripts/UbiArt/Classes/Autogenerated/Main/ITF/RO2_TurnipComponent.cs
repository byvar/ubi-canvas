using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_TurnipComponent : RO2_AIComponent {
		[Serialize("actorSpawnedPath")] public Path actorSpawnedPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(actorSpawnedPath));
		}
		public override uint? ClassCRC => 0x1EBE455E;
	}
}

