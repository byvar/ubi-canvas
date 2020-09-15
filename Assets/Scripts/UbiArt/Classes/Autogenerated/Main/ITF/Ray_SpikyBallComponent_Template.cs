using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_SpikyBallComponent_Template : CSerializable {
		public Placeholder circles;
		public Placeholder transitions;
		public Path texturePath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			circles = s.SerializeObject<Placeholder>(circles, name: "circles");
			transitions = s.SerializeObject<Placeholder>(transitions, name: "transitions");
			texturePath = s.SerializeObject<Path>(texturePath, name: "texturePath");
		}
		public override uint? ClassCRC => 0x5600BB01;
	}
}

