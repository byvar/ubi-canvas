using UnityEngine;

namespace UbiArt.ITF {
	public partial class TimedSpawnerAIComponent : AIComponent {
		[Serialize("spawnData")] public TimedSpawnerData spawnData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(spawnData));
		}
		public override uint? ClassCRC => 0xF3FC1E91;
	}
}

