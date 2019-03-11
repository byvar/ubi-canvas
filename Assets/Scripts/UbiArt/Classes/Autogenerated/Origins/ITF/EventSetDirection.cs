using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventSetDirection : CSerializable {
		[Serialize("direction")] public Vector2 direction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(direction));
		}
		public override uint? ClassCRC => 0x0B2DF3EA;
	}
}

