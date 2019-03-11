using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BubbleSpawnerComponent_Template : ActorComponent_Template {
		[Serialize("bubblePath")] public Path bubblePath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bubblePath));
		}
		public override uint? ClassCRC => 0x9A282E92;
	}
}

