namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class BTActionJumpToTarget_Template : BTAction_Template {
		public StringID anim;
		public StringID factTargetActor;
		public StringID factTargetPos;
		public bool followMovingTarget;
		public bool usePhysicJump;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RO) {
				anim = s.SerializeObject<StringID>(anim, name: "anim");
				factTargetActor = s.SerializeObject<StringID>(factTargetActor, name: "factTargetActor");
				factTargetPos = s.SerializeObject<StringID>(factTargetPos, name: "factTargetPos");
			} else {
				anim = s.SerializeObject<StringID>(anim, name: "anim");
				factTargetActor = s.SerializeObject<StringID>(factTargetActor, name: "factTargetActor");
				factTargetPos = s.SerializeObject<StringID>(factTargetPos, name: "factTargetPos");
				followMovingTarget = s.Serialize<bool>(followMovingTarget, name: "followMovingTarget");
				usePhysicJump = s.Serialize<bool>(usePhysicJump, name: "usePhysicJump");
			}
		}
		public override uint? ClassCRC => 0x5AE94BD1;
	}
}

