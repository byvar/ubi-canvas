using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PlayerCostumePriceComponent_Template : CSerializable {
		[Serialize("offset"      )] public Vector2 offset;
		[Serialize("bone"        )] public StringID bone;
		[Serialize("electoonPath")] public Path electoonPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(offset));
			SerializeField(s, nameof(bone));
			SerializeField(s, nameof(electoonPath));
		}
		public override uint? ClassCRC => 0xC8D513A6;
	}
}

