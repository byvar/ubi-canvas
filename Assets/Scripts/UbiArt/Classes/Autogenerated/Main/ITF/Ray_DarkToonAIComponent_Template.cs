using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_DarkToonAIComponent_Template : Ray_GroundAIComponent_Template {
		[Serialize("windBehavior"  )] public Placeholder windBehavior;
		[Serialize("waterBehavior" )] public Placeholder waterBehavior;
		[Serialize("launchBehavior")] public Placeholder launchBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(windBehavior));
			SerializeField(s, nameof(waterBehavior));
			SerializeField(s, nameof(launchBehavior));
		}
		public override uint? ClassCRC => 0xF3A80B9B;
	}
}

