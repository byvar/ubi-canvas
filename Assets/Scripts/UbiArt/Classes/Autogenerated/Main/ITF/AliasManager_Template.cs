using UnityEngine;

namespace UbiArt.ITF {
	public partial class AliasManager_Template : CSerializable {
		[Serialize("Alias")] public CMap<StringID, Path> Alias;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Alias));
		}
		public override uint? ClassCRC => 0xF4734BB3;
	}
}

