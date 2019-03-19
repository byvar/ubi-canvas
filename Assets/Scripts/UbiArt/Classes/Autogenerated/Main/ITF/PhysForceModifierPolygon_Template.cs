using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class PhysForceModifierPolygon_Template : PhysForceModifier_Template {
		[Serialize("polygon"      )] public PhysShapePolygon polygon;
		[Serialize("direction"    )] public Vector2 direction;
		[Serialize("centre"       )] public Vector2 centre;
		[Serialize("fallOffStart" )] public float fallOffStart;
		[Serialize("fallOffEnd"   )] public float fallOffEnd;
		[Serialize("gradientStart")] public float gradientStart;
		[Serialize("gradientEnd"  )] public float gradientEnd;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(gradientStart));
				SerializeField(s, nameof(gradientEnd));
			} else {
				SerializeField(s, nameof(polygon));
				SerializeField(s, nameof(direction));
				SerializeField(s, nameof(centre));
				SerializeField(s, nameof(fallOffStart));
				SerializeField(s, nameof(fallOffEnd));
			}
		}
		public override uint? ClassCRC => 0xFE78AAD8;
	}
}

