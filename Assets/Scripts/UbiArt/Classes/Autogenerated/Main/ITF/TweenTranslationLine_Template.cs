using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class TweenTranslationLine_Template : TweenTranslation_Template {
		public Vec3d movement;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			movement = s.SerializeObject<Vec3d>(movement, name: "movement");
		}
		public override uint? ClassCRC => 0xE63A5FEA;
	}
}

