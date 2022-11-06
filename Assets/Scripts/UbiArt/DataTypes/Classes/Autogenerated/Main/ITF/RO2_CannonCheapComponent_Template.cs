using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_CannonCheapComponent_Template : RO2_AIComponent_Template {
		public StringID animStand;
		public StringID animFire;
		public StringID animBullet;
		public float coolDownMin;
		public float coolDownMax;
		public Vec2d dir;
		public Vec2d startOffset;
		public float speed;
		public float distMax;
		public float bulletScale;
		public bool useRandomStart;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animStand = s.SerializeObject<StringID>(animStand, name: "animStand");
			animFire = s.SerializeObject<StringID>(animFire, name: "animFire");
			animBullet = s.SerializeObject<StringID>(animBullet, name: "animBullet");
			coolDownMin = s.Serialize<float>(coolDownMin, name: "coolDownMin");
			coolDownMax = s.Serialize<float>(coolDownMax, name: "coolDownMax");
			dir = s.SerializeObject<Vec2d>(dir, name: "dir");
			startOffset = s.SerializeObject<Vec2d>(startOffset, name: "startOffset");
			speed = s.Serialize<float>(speed, name: "speed");
			distMax = s.Serialize<float>(distMax, name: "distMax");
			bulletScale = s.Serialize<float>(bulletScale, name: "bulletScale");
			useRandomStart = s.Serialize<bool>(useRandomStart, name: "useRandomStart");
		}
		public override uint? ClassCRC => 0xD00991B1;
	}
}

