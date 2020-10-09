using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AnimMarkerEvent : Event {
		public StringID name;
		public Vec2d posLocal;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			posLocal = s.SerializeObject<Vec2d>(posLocal, name: "posLocal");
		}
		public override uint? ClassCRC => 0x2CF531DD;
	}
}

