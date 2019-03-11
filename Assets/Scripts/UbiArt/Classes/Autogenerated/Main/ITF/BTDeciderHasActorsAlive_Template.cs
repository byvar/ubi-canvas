using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTDeciderHasActorsAlive_Template : BTDecider_Template {
		[Serialize("invert"   )] public bool invert;
		[Serialize("checkAll" )] public bool checkAll;
		[Serialize("factActor")] public StringID factActor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(invert));
			SerializeField(s, nameof(checkAll));
			SerializeField(s, nameof(factActor));
		}
		public override uint? ClassCRC => 0x038DF1DE;
	}
}

