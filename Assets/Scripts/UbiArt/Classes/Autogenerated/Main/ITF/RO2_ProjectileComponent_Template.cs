using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ProjectileComponent_Template : ActorComponent_Template {
		[Serialize("animAppear"    )] public StringID animAppear;
		[Serialize("animHold"      )] public StringID animHold;
		[Serialize("animEjected"   )] public StringID animEjected;
		[Serialize("animExplode"   )] public StringID animExplode;
		[Serialize("rotationSpeed" )] public Angle rotationSpeed;
		[Serialize("faction"       )] public uint faction;
		[Serialize("bouncingFactor")] public float bouncingFactor;
		[Serialize("lifeDuration"  )] public float lifeDuration;
		[Serialize("collisionShape")] public Generic<PhysShape> collisionShape;
		[Serialize("reward"        )] public uint reward;
		[Serialize("CanExplode"    )] public bool CanExplode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(animAppear));
				SerializeField(s, nameof(animHold));
				SerializeField(s, nameof(animEjected));
				SerializeField(s, nameof(animExplode));
				SerializeField(s, nameof(rotationSpeed));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(bouncingFactor));
				SerializeField(s, nameof(lifeDuration));
				SerializeField(s, nameof(collisionShape));
				SerializeField(s, nameof(reward));
			} else {
				SerializeField(s, nameof(animAppear));
				SerializeField(s, nameof(animHold));
				SerializeField(s, nameof(animEjected));
				SerializeField(s, nameof(animExplode));
				SerializeField(s, nameof(rotationSpeed));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(bouncingFactor));
				SerializeField(s, nameof(lifeDuration));
				SerializeField(s, nameof(collisionShape));
				SerializeField(s, nameof(reward));
				SerializeField(s, nameof(CanExplode));
			}
		}
		public override uint? ClassCRC => 0x20669ACB;
	}
}

