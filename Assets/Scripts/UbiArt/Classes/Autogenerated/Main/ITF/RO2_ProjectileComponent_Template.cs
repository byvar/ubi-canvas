using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ProjectileComponent_Template : ActorComponent_Template {
		public StringID animAppear;
		public StringID animHold;
		public StringID animEjected;
		public StringID animExplode;
		public Angle rotationSpeed;
		public uint faction;
		public float bouncingFactor;
		public float lifeDuration;
		public Generic<PhysShape> collisionShape;
		public uint reward;
		public bool CanExplode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				animAppear = s.SerializeObject<StringID>(animAppear, name: "animAppear");
				animHold = s.SerializeObject<StringID>(animHold, name: "animHold");
				animEjected = s.SerializeObject<StringID>(animEjected, name: "animEjected");
				animExplode = s.SerializeObject<StringID>(animExplode, name: "animExplode");
				rotationSpeed = s.SerializeObject<Angle>(rotationSpeed, name: "rotationSpeed");
				faction = s.Serialize<uint>(faction, name: "faction");
				bouncingFactor = s.Serialize<float>(bouncingFactor, name: "bouncingFactor");
				lifeDuration = s.Serialize<float>(lifeDuration, name: "lifeDuration");
				collisionShape = s.SerializeObject<Generic<PhysShape>>(collisionShape, name: "collisionShape");
				reward = s.Serialize<uint>(reward, name: "reward");
			} else {
				animAppear = s.SerializeObject<StringID>(animAppear, name: "animAppear");
				animHold = s.SerializeObject<StringID>(animHold, name: "animHold");
				animEjected = s.SerializeObject<StringID>(animEjected, name: "animEjected");
				animExplode = s.SerializeObject<StringID>(animExplode, name: "animExplode");
				rotationSpeed = s.SerializeObject<Angle>(rotationSpeed, name: "rotationSpeed");
				faction = s.Serialize<uint>(faction, name: "faction");
				bouncingFactor = s.Serialize<float>(bouncingFactor, name: "bouncingFactor");
				lifeDuration = s.Serialize<float>(lifeDuration, name: "lifeDuration");
				collisionShape = s.SerializeObject<Generic<PhysShape>>(collisionShape, name: "collisionShape");
				reward = s.Serialize<uint>(reward, name: "reward");
				CanExplode = s.Serialize<bool>(CanExplode, name: "CanExplode");
			}
		}
		public override uint? ClassCRC => 0x20669ACB;
	}
}

