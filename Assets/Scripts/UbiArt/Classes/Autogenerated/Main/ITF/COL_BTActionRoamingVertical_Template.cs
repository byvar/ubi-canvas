using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTActionRoamingVertical_Template : CSerializable {
		[Serialize("name"    )] public StringID name;
		[Serialize("animUp"  )] public StringID animUp;
		[Serialize("animDown")] public StringID animDown;
		[Serialize("animIdle")] public StringID animIdle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(animUp));
			SerializeField(s, nameof(animDown));
			SerializeField(s, nameof(animIdle));
		}
		public override uint? ClassCRC => 0x549518B2;
	}
}

