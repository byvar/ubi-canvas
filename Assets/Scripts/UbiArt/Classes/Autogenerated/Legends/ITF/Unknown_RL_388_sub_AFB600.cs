using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_388_sub_AFB600 : CSerializable {
		public LocalisationId locID;
		public Path textPath;
		public Vec2d screenPos;
		public float displayDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			locID = s.SerializeObject<LocalisationId>(locID, name: "locID");
			textPath = s.SerializeObject<Path>(textPath, name: "textPath");
			screenPos = s.SerializeObject<Vec2d>(screenPos, name: "screenPos");
			displayDuration = s.Serialize<float>(displayDuration, name: "displayDuration");
		}
		public override uint? ClassCRC => 0xBD34A8A0;
	}
}

