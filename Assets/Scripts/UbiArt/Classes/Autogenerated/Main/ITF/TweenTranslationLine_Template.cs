using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class TweenTranslationLine_Template : TweenTranslation_Template {
		[Serialize("movement")] public Vec3d movement;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(movement));
		}
		public override uint? ClassCRC => 0xE63A5FEA;
	}
}

