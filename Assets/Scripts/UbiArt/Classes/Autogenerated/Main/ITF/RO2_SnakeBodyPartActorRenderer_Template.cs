using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SnakeBodyPartActorRenderer_Template : RO2_SnakeBodyPartRenderer_Template {
		[Serialize("actorPath"    )] public Path actorPath;
		[Serialize("polyline"     )] public StringID polyline;
		[Serialize("otherPolyline")] public StringID otherPolyline;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(actorPath));
			SerializeField(s, nameof(polyline));
			SerializeField(s, nameof(otherPolyline));
		}
		public override uint? ClassCRC => 0xCCE951C8;
	}
}

