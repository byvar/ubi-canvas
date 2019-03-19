using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIDarktoonLaunchBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("ballistics")] public Placeholder ballistics;
		[Serialize("landing"   )] public Placeholder landing;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ballistics));
			SerializeField(s, nameof(landing));
		}
		public override uint? ClassCRC => 0x20A3A4D8;
	}
}

