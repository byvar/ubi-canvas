using UnityEngine;

namespace UbiArt.ITF {
	public partial class BasicIKComponent_Template : ActorComponent_Template {
		[Serialize("defaultProcess")] public bool defaultProcess;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(defaultProcess));
		}
		public override uint? ClassCRC => 0xBF2A28E6;
	}
}

