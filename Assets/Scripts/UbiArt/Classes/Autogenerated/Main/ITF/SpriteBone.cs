using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class SpriteBone : CSerializable {
		public StringID name;
		public Vec2d p0;
		public Vec2d p1;
		public Vec2d uv0;
		public Vec2d uv1;
		public float z;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			p0 = s.SerializeObject<Vec2d>(p0, name: "p0");
			p1 = s.SerializeObject<Vec2d>(p1, name: "p1");
			uv0 = s.SerializeObject<Vec2d>(uv0, name: "uv0");
			uv1 = s.SerializeObject<Vec2d>(uv1, name: "uv1");
			if (Settings.s.game == Settings.Game.RA || Settings.s.game == Settings.Game.RM || Settings.s.game == Settings.Game.VH) {
				z = s.Serialize<float>(z, name: "z");
			}
		}
	}
}

