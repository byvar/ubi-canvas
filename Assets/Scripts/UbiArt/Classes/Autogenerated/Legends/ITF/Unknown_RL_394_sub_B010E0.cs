using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_394_sub_B010E0 : CSerializable {
		[Serialize("drcTapEnabled"        )] public int drcTapEnabled;
		[Serialize("drcSwipeEnabled"      )] public int drcSwipeEnabled;
		[Serialize("drcHoldEnabled"       )] public int drcHoldEnabled;
		[Serialize("dragOffsetUp"         )] public float dragOffsetUp;
		[Serialize("dragForceWeight_Left" )] public float dragForceWeight_Left;
		[Serialize("dragForceWeight_Right")] public float dragForceWeight_Right;
		[Serialize("dragForceWeight_Up"   )] public float dragForceWeight_Up;
		[Serialize("dragForceWeight_Down" )] public float dragForceWeight_Down;
		[Serialize("dragForceDistance"    )] public float dragForceDistance;
		[Serialize("speed"                )] public float speed;
		[Serialize("dragForceFadeWeight"  )] public float dragForceFadeWeight;
		[Serialize("turningAngleMax"      )] public Angle turningAngleMax;
		[Serialize("normMinToMove"        )] public float normMinToMove;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(drcTapEnabled));
			SerializeField(s, nameof(drcSwipeEnabled));
			SerializeField(s, nameof(drcHoldEnabled));
			SerializeField(s, nameof(dragOffsetUp));
			SerializeField(s, nameof(dragForceWeight_Left));
			SerializeField(s, nameof(dragForceWeight_Right));
			SerializeField(s, nameof(dragForceWeight_Up));
			SerializeField(s, nameof(dragForceWeight_Down));
			SerializeField(s, nameof(dragForceDistance));
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(dragForceFadeWeight));
			SerializeField(s, nameof(turningAngleMax));
			SerializeField(s, nameof(normMinToMove));
		}
		public override uint? ClassCRC => 0x2AC12BCC;
	}
}

