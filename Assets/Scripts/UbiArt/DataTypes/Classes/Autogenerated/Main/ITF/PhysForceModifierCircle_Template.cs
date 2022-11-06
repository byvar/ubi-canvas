using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class PhysForceModifierCircle_Template : PhysForceModifier_Template {
		public float radius;
		public Angle angleStart;
		public Angle angleEnd;
		public Angle gradientAngleOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.COL) {
				radius = s.Serialize<float>(radius, name: "radius");
				angleStart = s.SerializeObject<Angle>(angleStart, name: "angleStart");
				angleEnd = s.SerializeObject<Angle>(angleEnd, name: "angleEnd");
				gradientAngleOffset = s.SerializeObject<Angle>(gradientAngleOffset, name: "gradientAngleOffset");
			} else {
				radius = s.Serialize<float>(radius, name: "radius");
				angleStart = s.SerializeObject<Angle>(angleStart, name: "angleStart");
				angleEnd = s.SerializeObject<Angle>(angleEnd, name: "angleEnd");
			}
		}
		public override uint? ClassCRC => 0xD8719B69;
	}
}

