using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_125_sub_7335D0 : CSerializable {
		[Serialize("levelSelectFriendly")] public PathRef levelSelectFriendly;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(levelSelectFriendly));
		}
		public override uint? ClassCRC => 0xBFB1ED03;
	}
}

