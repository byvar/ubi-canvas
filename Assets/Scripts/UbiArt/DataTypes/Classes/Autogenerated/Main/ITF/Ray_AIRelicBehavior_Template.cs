using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIRelicBehavior_Template : TemplateAIBehavior {
		public int relicIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			relicIndex = s.Serialize<int>(relicIndex, name: "relicIndex");
		}
		public override uint? ClassCRC => 0x8F5D37B9;
	}
}

