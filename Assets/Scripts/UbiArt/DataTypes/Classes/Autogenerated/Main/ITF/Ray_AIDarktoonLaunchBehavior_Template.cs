using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIDarktoonLaunchBehavior_Template : TemplateAIBehavior {
		public Placeholder ballistics;
		public Placeholder landing;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ballistics = s.SerializeObject<Placeholder>(ballistics, name: "ballistics");
			landing = s.SerializeObject<Placeholder>(landing, name: "landing");
		}
		public override uint? ClassCRC => 0x20A3A4D8;
	}
}

