using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionRunDarktoonified_Template : BTAction_Template {
		[Serialize("walkAnim"              )] public StringID walkAnim;
		[Serialize("swimAnim"              )] public StringID swimAnim;
		[Serialize("fallAnim"              )] public StringID fallAnim;
		[Serialize("flyFallAnim"           )] public StringID flyFallAnim;
		[Serialize("crashWallAnim"         )] public StringID crashWallAnim;
		[Serialize("launchIdleMinTime"     )] public float launchIdleMinTime;
		[Serialize("launchIdleMaxTime"     )] public float launchIdleMaxTime;
		[Serialize("stayIdleMinTime"       )] public float stayIdleMinTime;
		[Serialize("stayIdleMaxTime"       )] public float stayIdleMaxTime;
		[Serialize("flyFallSpeedMultiplier")] public float flyFallSpeedMultiplier;
		[Serialize("canRunInTheAir"        )] public bool canRunInTheAir;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(walkAnim));
			SerializeField(s, nameof(swimAnim));
			SerializeField(s, nameof(fallAnim));
			SerializeField(s, nameof(flyFallAnim));
			SerializeField(s, nameof(crashWallAnim));
			SerializeField(s, nameof(launchIdleMinTime));
			SerializeField(s, nameof(launchIdleMaxTime));
			SerializeField(s, nameof(stayIdleMinTime));
			SerializeField(s, nameof(stayIdleMaxTime));
			SerializeField(s, nameof(flyFallSpeedMultiplier));
			SerializeField(s, nameof(canRunInTheAir));
		}
		public override uint? ClassCRC => 0xF1CACB88;
	}
}

