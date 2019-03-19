using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_TeleportTargetComponent : CSerializable {
		[Serialize("arriveFromInfos")] public Placeholder arriveFromInfos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(arriveFromInfos));
		}
		public override uint? ClassCRC => 0xCE462DAB;
	}
}

