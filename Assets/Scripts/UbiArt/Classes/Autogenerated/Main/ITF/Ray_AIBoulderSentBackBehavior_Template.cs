using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIBoulderSentBackBehavior_Template : TemplateAIBehavior {
		public float gravity;
		public float friction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			gravity = s.Serialize<float>(gravity, name: "gravity");
			friction = s.Serialize<float>(friction, name: "friction");
		}
		public override uint? ClassCRC => 0xE282EE83;
	}
}

