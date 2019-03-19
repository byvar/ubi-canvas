using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PALTeensieSpawnerComponent_Template : ActorComponent_Template {
		[Serialize("helpFX")] public StringID helpFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(helpFX));
		}
		public override uint? ClassCRC => 0x1F9E6AE9;
	}
}

