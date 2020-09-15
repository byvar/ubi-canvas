using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BossBuboAIComponent_Template : CSerializable {
		public StringID invisibleAnim;
		public StringID appearAnim;
		public StringID disappearAnim;
		public StringID hitAnim;
		public StringID deathAnim;
		public uint allowedFaction;
		public uint nbRewards;
		public int triggerActivator;
		public int delayTrigger;
		public int isCrushable;
		public int isMegaBubo;
		public uint megaBuboHitPoints;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			invisibleAnim = s.SerializeObject<StringID>(invisibleAnim, name: "invisibleAnim");
			appearAnim = s.SerializeObject<StringID>(appearAnim, name: "appearAnim");
			disappearAnim = s.SerializeObject<StringID>(disappearAnim, name: "disappearAnim");
			hitAnim = s.SerializeObject<StringID>(hitAnim, name: "hitAnim");
			deathAnim = s.SerializeObject<StringID>(deathAnim, name: "deathAnim");
			allowedFaction = s.Serialize<uint>(allowedFaction, name: "allowedFaction");
			nbRewards = s.Serialize<uint>(nbRewards, name: "nbRewards");
			triggerActivator = s.Serialize<int>(triggerActivator, name: "triggerActivator");
			delayTrigger = s.Serialize<int>(delayTrigger, name: "delayTrigger");
			isCrushable = s.Serialize<int>(isCrushable, name: "isCrushable");
			isMegaBubo = s.Serialize<int>(isMegaBubo, name: "isMegaBubo");
			megaBuboHitPoints = s.Serialize<uint>(megaBuboHitPoints, name: "megaBuboHitPoints");
		}
		public override uint? ClassCRC => 0x3003CC7E;
	}
}

