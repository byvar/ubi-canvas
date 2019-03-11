using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_DanceStoneComponent_Template : CSerializable {
		[Serialize("dancerShouldFlip"  )] public bool dancerShouldFlip;
		[Serialize("upTempo"           )] public Placeholder upTempo;
		[Serialize("downTempo"         )] public Placeholder downTempo;
		[Serialize("syncRatio"         )] public float syncRatio;
		[Serialize("syncOffset"        )] public float syncOffset;
		[Serialize("numTemposToUnlock" )] public uint numTemposToUnlock;
		[Serialize("distXSnap"         )] public float distXSnap;
		[Serialize("distYSnap"         )] public float distYSnap;
		[Serialize("numLumNormalReward")] public uint numLumNormalReward;
		[Serialize("numLumPowerReward" )] public uint numLumPowerReward;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(dancerShouldFlip));
			SerializeField(s, nameof(upTempo));
			SerializeField(s, nameof(downTempo));
			SerializeField(s, nameof(syncRatio));
			SerializeField(s, nameof(syncOffset));
			SerializeField(s, nameof(numTemposToUnlock));
			SerializeField(s, nameof(distXSnap));
			SerializeField(s, nameof(distYSnap));
			SerializeField(s, nameof(numLumNormalReward));
			SerializeField(s, nameof(numLumPowerReward));
		}
		public override uint? ClassCRC => 0xA0D4FA77;
	}
}

