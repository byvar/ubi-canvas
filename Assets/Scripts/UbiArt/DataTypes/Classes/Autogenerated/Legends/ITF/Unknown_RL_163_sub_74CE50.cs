using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_163_sub_74CE50 : CSerializable {
		public Path murphyIconPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			murphyIconPath = s.SerializeObject<Path>(murphyIconPath, name: "murphyIconPath");
		}
		public override uint? ClassCRC => 0x8697A56D;
	}
}

