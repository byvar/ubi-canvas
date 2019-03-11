using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventStoneManLaunch : CSerializable {
		[Serialize("actionIndex")] public uint actionIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(actionIndex));
		}
		public override uint? ClassCRC => 0xDDDAD568;
	}
}

