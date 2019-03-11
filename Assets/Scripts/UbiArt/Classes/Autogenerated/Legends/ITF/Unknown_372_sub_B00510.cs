using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_372_sub_B00510 : CSerializable {
		[Serialize("drcTapEnabled"      )] public bool drcTapEnabled;
		[Serialize("drcSwipeEnabled"    )] public bool drcSwipeEnabled;
		[Serialize("drcHoldEnabled"     )] public bool drcHoldEnabled;
		[Serialize("swiperBidirectional")] public bool swiperBidirectional;
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

