using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class DOGController_Template : ActorComponent_Template {
		[Serialize("bool__0")] public bool bool__0;
		[Serialize("Path__1")] public Path Path__1;
		[Serialize("Path__2")] public Path Path__2;
		[Serialize("Path__3")] public Path Path__3;
		[Serialize("Path__4")] public Path Path__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(Path__1));
			SerializeField(s, nameof(Path__2));
			SerializeField(s, nameof(Path__3));
			SerializeField(s, nameof(Path__4));
		}
		public override uint? ClassCRC => 0x9805C852;
	}
}

