using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_SnakeBodyPartActorRenderer_Template : RO2_SnakeBodyPartRenderer_Template {
		public Path actorPath;
		public StringID polyline;
		public StringID otherPolyline;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			actorPath = s.SerializeObject<Path>(actorPath, name: "actorPath");
			polyline = s.SerializeObject<StringID>(polyline, name: "polyline");
			otherPolyline = s.SerializeObject<StringID>(otherPolyline, name: "otherPolyline");
		}
		public override uint? ClassCRC => 0xCCE951C8;
	}
}

