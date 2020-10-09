using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class AIFollowActorAction_Template : AIAction_Template {
		public Vec3d aiFollowActorRelativPos;
		public Vec3d aiFollowActorRelativPosNext;
		public float aiFollowActorAcceleration;
		public float aiFollowActorFriction;
		public bool aiFollowActorDoFlip;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			aiFollowActorRelativPos = s.SerializeObject<Vec3d>(aiFollowActorRelativPos, name: "aiFollowActorRelativPos");
			aiFollowActorRelativPosNext = s.SerializeObject<Vec3d>(aiFollowActorRelativPosNext, name: "aiFollowActorRelativPosNext");
			aiFollowActorAcceleration = s.Serialize<float>(aiFollowActorAcceleration, name: "aiFollowActorAcceleration");
			aiFollowActorFriction = s.Serialize<float>(aiFollowActorFriction, name: "aiFollowActorFriction");
			aiFollowActorDoFlip = s.Serialize<bool>(aiFollowActorDoFlip, name: "aiFollowActorDoFlip");
		}
		public override uint? ClassCRC => 0x4E176A36;
	}
}

