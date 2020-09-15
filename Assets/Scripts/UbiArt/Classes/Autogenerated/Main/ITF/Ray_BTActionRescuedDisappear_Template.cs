using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BTActionRescuedDisappear_Template : BTAction_Template {
		public StringID happyAnim;
		public Path spawnFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			happyAnim = s.SerializeObject<StringID>(happyAnim, name: "happyAnim");
			spawnFX = s.SerializeObject<Path>(spawnFX, name: "spawnFX");
		}
		public override uint? ClassCRC => 0x37645524;
	}
}

