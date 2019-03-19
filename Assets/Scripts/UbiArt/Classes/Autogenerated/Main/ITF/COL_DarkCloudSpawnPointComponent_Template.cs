using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DarkCloudSpawnPointComponent_Template : CSerializable {
		[Serialize("activationDistance")] public float activationDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(activationDistance));
		}
		public override uint? ClassCRC => 0x546651E5;
	}
}

