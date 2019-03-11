using UnityEngine;

namespace UbiArt.ITF {
	public partial class CheckpointComponent_Template : ActorComponent_Template {
		[Serialize("spawnPlayer")] public bool spawnPlayer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(spawnPlayer));
		}
		public override uint? ClassCRC => 0x0F8AF4A2;
	}
}

