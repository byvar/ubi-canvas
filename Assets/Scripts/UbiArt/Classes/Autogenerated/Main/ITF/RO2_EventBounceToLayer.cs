using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventBounceToLayer : Event {
		public float bounceHeight;
		public float bounceHeight2;
		public float bounceSpeed;
		public ObjectRef targetActor;
		public Vec3d targetPos;
		public Vec2d targetOffset;
		public bool hurt;
		public bool skipped;
		public bool useTargetActorScenePosZ;
		public bool useBounceHeight;
		public uint hurt2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				bounceHeight = s.Serialize<float>(bounceHeight, name: "bounceHeight");
				bounceHeight2 = s.Serialize<float>(bounceHeight2, name: "bounceHeight2");
				bounceSpeed = s.Serialize<float>(bounceSpeed, name: "bounceSpeed");
				targetActor = (ObjectRef)s.Serialize<uint>((uint)targetActor, name: "targetActor");
				targetPos = s.SerializeObject<Vec3d>(targetPos, name: "targetPos");
				targetOffset = s.SerializeObject<Vec2d>(targetOffset, name: "targetOffset");
				hurt2 = s.Serialize<uint>(hurt2, name: "hurt");
				skipped = s.Serialize<bool>(skipped, name: "skipped");
				useTargetActorScenePosZ = s.Serialize<bool>(useTargetActorScenePosZ, name: "useTargetActorScenePosZ");
				useBounceHeight = s.Serialize<bool>(useBounceHeight, name: "useBounceHeight");
			} else {
				bounceHeight = s.Serialize<float>(bounceHeight, name: "bounceHeight");
				bounceHeight2 = s.Serialize<float>(bounceHeight2, name: "bounceHeight2");
				bounceSpeed = s.Serialize<float>(bounceSpeed, name: "bounceSpeed");
				targetActor = s.SerializeObject<ObjectRef>(targetActor, name: "targetActor");
				targetPos = s.SerializeObject<Vec3d>(targetPos, name: "targetPos");
				targetOffset = s.SerializeObject<Vec2d>(targetOffset, name: "targetOffset");
				hurt = s.Serialize<bool>(hurt, name: "hurt");
				skipped = s.Serialize<bool>(skipped, name: "skipped");
				useTargetActorScenePosZ = s.Serialize<bool>(useTargetActorScenePosZ, name: "useTargetActorScenePosZ");
				useBounceHeight = s.Serialize<bool>(useBounceHeight, name: "useBounceHeight");
			}
		}
		public override uint? ClassCRC => 0xE0E48A5E;
	}
}

