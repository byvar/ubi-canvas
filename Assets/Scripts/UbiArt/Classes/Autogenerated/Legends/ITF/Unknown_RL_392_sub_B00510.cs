using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_392_sub_B00510 : CSerializable {
		[Serialize("drcTapEnabled"      )] public int drcTapEnabled;
		[Serialize("drcSwipeEnabled"    )] public int drcSwipeEnabled;
		[Serialize("drcHoldEnabled"     )] public int drcHoldEnabled;
		[Serialize("swiperBidirectional")] public int swiperBidirectional;
		[Serialize("swipeMinLength"     )] public float swipeMinLength;
		[Serialize("swipeAngleTolerance")] public Angle swipeAngleTolerance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(drcTapEnabled));
			SerializeField(s, nameof(drcSwipeEnabled));
			SerializeField(s, nameof(drcHoldEnabled));
			SerializeField(s, nameof(swiperBidirectional));
			SerializeField(s, nameof(swipeMinLength));
			SerializeField(s, nameof(swipeAngleTolerance));
		}
		public override uint? ClassCRC => 0xA1DE912B;
	}
}

