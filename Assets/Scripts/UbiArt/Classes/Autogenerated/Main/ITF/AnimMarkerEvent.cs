using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimMarkerEvent : Event {
		[Serialize("name"    )] public StringID name;
		[Serialize("posLocal")] public Vector2 posLocal;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(posLocal));
		}
		public override uint? ClassCRC => 0x2CF531DD;
	}
}

