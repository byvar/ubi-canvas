using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class EnvironmentComponent : CSerializable {
		[Serialize("Environment")] public SoundGUID Environment;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Environment));
		}
		public override uint? ClassCRC => 0xFD7E5952;
	}
}

