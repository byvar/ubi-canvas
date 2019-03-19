using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BTActionRescuedDisappear_Template : BTAction_Template {
		[Serialize("happyAnim")] public StringID happyAnim;
		[Serialize("spawnFX"  )] public Path spawnFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(happyAnim));
			SerializeField(s, nameof(spawnFX));
		}
		public override uint? ClassCRC => 0x37645524;
	}
}

