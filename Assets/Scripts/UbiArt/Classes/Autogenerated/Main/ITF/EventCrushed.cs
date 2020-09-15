using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventCrushed : Event {
		public CHARACTERSIZE characterSize;
		public Vec2d direction;
		public Vec3d fxPos;
		public bool bounce;
		public float bounceMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
			} else {
				characterSize = s.Serialize<CHARACTERSIZE>(characterSize, name: "characterSize");
				direction = s.SerializeObject<Vec2d>(direction, name: "direction");
				fxPos = s.SerializeObject<Vec3d>(fxPos, name: "fxPos");
				bounce = s.Serialize<bool>(bounce, name: "bounce");
				bounceMultiplier = s.Serialize<float>(bounceMultiplier, name: "bounceMultiplier");
			}
		}
		public enum CHARACTERSIZE {
			[Serialize("CHARACTERSIZE_SMALL" )] SMALL = 0,
			[Serialize("CHARACTERSIZE_NORMAL")] NORMAL = 1,
			[Serialize("CHARACTERSIZE_BIG"   )] BIG = 2,
		}
		public override uint? ClassCRC => 0xE465E37F;
	}
}

