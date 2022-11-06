using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_PaintSwingManComponent_Template : ActorComponent_Template {
		public uint LumRewardNb;
		public StringID AnimPaint;
		public StringID AnimStand;
		public bool useAdditive;
		public StringID additiveInput;
		public float additiveDuration;
		public bool listenToStick;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			LumRewardNb = s.Serialize<uint>(LumRewardNb, name: "LumRewardNb");
			AnimPaint = s.SerializeObject<StringID>(AnimPaint, name: "AnimPaint");
			AnimStand = s.SerializeObject<StringID>(AnimStand, name: "AnimStand");
			useAdditive = s.Serialize<bool>(useAdditive, name: "useAdditive");
			additiveInput = s.SerializeObject<StringID>(additiveInput, name: "additiveInput");
			additiveDuration = s.Serialize<float>(additiveDuration, name: "additiveDuration");
			listenToStick = s.Serialize<bool>(listenToStick, name: "listenToStick");
		}
		public override uint? ClassCRC => 0x3FC2E243;
	}
}

