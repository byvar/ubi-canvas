using UnityEngine;

namespace UbiArt.ITF {
	public partial class PhysForceModifierPolygon_Template : PhysForceModifier_Template {
		[Serialize("polygon"     )] public PhysShapePolygon polygon;
		[Serialize("direction"   )] public Vector2 direction;
		[Serialize("centre"      )] public Vector2 centre;
		[Serialize("fallOffStart")] public float fallOffStart;
		[Serialize("fallOffEnd"  )] public float fallOffEnd;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
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

