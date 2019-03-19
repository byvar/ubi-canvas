using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_WikiShortcutCollectible_Template : ActorComponent_Template {
		[Serialize("CArray<uint>__0")] public CArray<uint> CArray_uint__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(CArray_uint__0));
		}
		public override uint? ClassCRC => 0xCBE9AD84;
	}
}

