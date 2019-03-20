using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIRelicBehavior_Template : TemplateAIBehavior {
		[Serialize("relicIndex")] public int relicIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(relicIndex));
		}
		public override uint? ClassCRC => 0x8F5D37B9;
	}
}

