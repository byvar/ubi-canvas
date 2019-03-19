using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_WatchAndDetect_Template : ActorComponent_Template {
		[Serialize("Path__0")] public Path Path__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Path__0));
		}
		public override uint? ClassCRC => 0x57ABD9C1;
	}
}

