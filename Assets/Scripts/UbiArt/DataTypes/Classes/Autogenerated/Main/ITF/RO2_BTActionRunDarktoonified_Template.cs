using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionRunDarktoonified_Template : BTAction_Template {
		public StringID walkAnim;
		public StringID swimAnim;
		public StringID fallAnim;
		public StringID flyFallAnim;
		public StringID crashWallAnim;
		public float launchIdleMinTime;
		public float launchIdleMaxTime;
		public float stayIdleMinTime;
		public float stayIdleMaxTime;
		public float flyFallSpeedMultiplier;
		public bool canRunInTheAir;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			walkAnim = s.SerializeObject<StringID>(walkAnim, name: "walkAnim");
			swimAnim = s.SerializeObject<StringID>(swimAnim, name: "swimAnim");
			fallAnim = s.SerializeObject<StringID>(fallAnim, name: "fallAnim");
			flyFallAnim = s.SerializeObject<StringID>(flyFallAnim, name: "flyFallAnim");
			crashWallAnim = s.SerializeObject<StringID>(crashWallAnim, name: "crashWallAnim");
			launchIdleMinTime = s.Serialize<float>(launchIdleMinTime, name: "launchIdleMinTime");
			launchIdleMaxTime = s.Serialize<float>(launchIdleMaxTime, name: "launchIdleMaxTime");
			stayIdleMinTime = s.Serialize<float>(stayIdleMinTime, name: "stayIdleMinTime");
			stayIdleMaxTime = s.Serialize<float>(stayIdleMaxTime, name: "stayIdleMaxTime");
			flyFallSpeedMultiplier = s.Serialize<float>(flyFallSpeedMultiplier, name: "flyFallSpeedMultiplier");
			canRunInTheAir = s.Serialize<bool>(canRunInTheAir, name: "canRunInTheAir");
		}
		public override uint? ClassCRC => 0xF1CACB88;
	}
}

