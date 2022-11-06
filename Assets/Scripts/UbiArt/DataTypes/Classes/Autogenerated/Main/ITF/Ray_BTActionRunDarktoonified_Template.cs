using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BTActionRunDarktoonified_Template : BTAction_Template {
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
		public int canRunInTheAir;
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
			canRunInTheAir = s.Serialize<int>(canRunInTheAir, name: "canRunInTheAir");
		}
		public override uint? ClassCRC => 0xE482F349;
	}
}

