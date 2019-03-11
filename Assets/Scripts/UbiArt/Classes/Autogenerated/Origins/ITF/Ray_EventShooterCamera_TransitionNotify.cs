using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventShooterCamera_TransitionNotify : CSerializable {
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
		}
		public override uint? ClassCRC => 0x1DE2F928;
	}
}

