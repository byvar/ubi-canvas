using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_CannonCheapComponent_Template : RO2_AIComponent_Template {
		[Serialize("animStand"     )] public StringID animStand;
		[Serialize("animFire"      )] public StringID animFire;
		[Serialize("animBullet"    )] public StringID animBullet;
		[Serialize("coolDownMin"   )] public float coolDownMin;
		[Serialize("coolDownMax"   )] public float coolDownMax;
		[Serialize("dir"           )] public Vec2d dir;
		[Serialize("startOffset"   )] public Vec2d startOffset;
		[Serialize("speed"         )] public float speed;
		[Serialize("distMax"       )] public float distMax;
		[Serialize("bulletScale"   )] public float bulletScale;
		[Serialize("useRandomStart")] public bool useRandomStart;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animStand));
			SerializeField(s, nameof(animFire));
			SerializeField(s, nameof(animBullet));
			SerializeField(s, nameof(coolDownMin));
			SerializeField(s, nameof(coolDownMax));
			SerializeField(s, nameof(dir));
			SerializeField(s, nameof(startOffset));
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(distMax));
			SerializeField(s, nameof(bulletScale));
			SerializeField(s, nameof(useRandomStart));
		}
		public override uint? ClassCRC => 0xD00991B1;
	}
}

