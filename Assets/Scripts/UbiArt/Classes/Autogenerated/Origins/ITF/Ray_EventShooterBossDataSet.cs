using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventShooterBossDataSet : Event {
		[Serialize("dataInt"  )] public bool dataInt;
		[Serialize("dataFloat")] public float dataFloat;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(dataInt));
			SerializeField(s, nameof(dataFloat));
		}
		public override uint? ClassCRC => 0xB7166F38;
	}
}

