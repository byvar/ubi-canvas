using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_122_sub_6E0980 : ActorComponent_Template {
		public float LookAtDist;
		public uint MaxLookAtModule;
		public float CheckAttackDistance;
		public float AttackDistance;
		public float PolylineDepthOffset;
		public StringID TailBone;
		public StringID HeadBone;
		public int DrawDebugHit;
		public float PropagationTimer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			LookAtDist = s.Serialize<float>(LookAtDist, name: "LookAtDist");
			MaxLookAtModule = s.Serialize<uint>(MaxLookAtModule, name: "MaxLookAtModule");
			CheckAttackDistance = s.Serialize<float>(CheckAttackDistance, name: "CheckAttackDistance");
			AttackDistance = s.Serialize<float>(AttackDistance, name: "AttackDistance");
			PolylineDepthOffset = s.Serialize<float>(PolylineDepthOffset, name: "PolylineDepthOffset");
			TailBone = s.SerializeObject<StringID>(TailBone, name: "TailBone");
			HeadBone = s.SerializeObject<StringID>(HeadBone, name: "HeadBone");
			DrawDebugHit = s.Serialize<int>(DrawDebugHit, name: "DrawDebugHit");
			PropagationTimer = s.Serialize<float>(PropagationTimer, name: "PropagationTimer");
		}
		public override uint? ClassCRC => 0x2DEB7659;
	}
}

