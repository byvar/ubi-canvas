using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Unknown_COL_24_sub_9589F0 : CSerializable {
		[Serialize("OnEnter"    )] public SoundGUID OnEnter;
		[Serialize("OnExit"     )] public SoundGUID OnExit;
		[Serialize("DepthOffset")] public float DepthOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(OnEnter));
			SerializeField(s, nameof(OnExit));
			SerializeField(s, nameof(DepthOffset));
		}
		public override uint? ClassCRC => 0x70479393;
	}
}

