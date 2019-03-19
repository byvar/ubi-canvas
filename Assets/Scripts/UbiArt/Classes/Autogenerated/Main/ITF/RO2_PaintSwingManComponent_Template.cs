using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PaintSwingManComponent_Template : ActorComponent_Template {
		[Serialize("LumRewardNb"     )] public uint LumRewardNb;
		[Serialize("AnimPaint"       )] public StringID AnimPaint;
		[Serialize("AnimStand"       )] public StringID AnimStand;
		[Serialize("useAdditive"     )] public bool useAdditive;
		[Serialize("additiveInput"   )] public StringID additiveInput;
		[Serialize("additiveDuration")] public float additiveDuration;
		[Serialize("listenToStick"   )] public bool listenToStick;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(LumRewardNb));
			SerializeField(s, nameof(AnimPaint));
			SerializeField(s, nameof(AnimStand));
			SerializeField(s, nameof(useAdditive));
			SerializeField(s, nameof(additiveInput));
			SerializeField(s, nameof(additiveDuration));
			SerializeField(s, nameof(listenToStick));
		}
		public override uint? ClassCRC => 0x3FC2E243;
	}
}

