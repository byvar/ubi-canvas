using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_CharDiaPageViewer : ActorComponent {
		[Serialize("Path__0"   )] public Path Path__0;
		[Serialize("Vector2__1")] public Vector2 Vector2__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Path__0));
			SerializeField(s, nameof(Vector2__1));
		}
		public override uint? ClassCRC => 0xEFCC6209;
	}
}

