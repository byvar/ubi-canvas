using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionRescuedDisappear_Template : BTAction_Template {
		public StringID happyAnim;
		public Path spawnFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			happyAnim = s.SerializeObject<StringID>(happyAnim, name: "happyAnim");
			spawnFX = s.SerializeObject<Path>(spawnFX, name: "spawnFX");
		}
		public override uint? ClassCRC => 0xA52CAE49;
	}
}

