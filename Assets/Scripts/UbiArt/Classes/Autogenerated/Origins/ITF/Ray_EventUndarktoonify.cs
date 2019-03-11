using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventUndarktoonify : CSerializable {
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
		}
		public override uint? ClassCRC => 0x88EA16CC;
	}
}

