using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_OceanSpiderAIComponent_Template : Ray_SimpleAIComponent_Template {
		[Serialize("addHitInputName")] public StringID addHitInputName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(addHitInputName));
		}
		public override uint? ClassCRC => 0xC316633B;
	}
}

