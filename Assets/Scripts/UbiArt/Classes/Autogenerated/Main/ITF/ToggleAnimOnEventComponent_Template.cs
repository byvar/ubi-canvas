using UnityEngine;

namespace UbiArt.ITF {
	public partial class ToggleAnimOnEventComponent_Template : ActorComponent_Template {
		[Serialize("openAnim" )] public StringID openAnim;
		[Serialize("closeAnim")] public StringID closeAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(openAnim));
			SerializeField(s, nameof(closeAnim));
		}
		public override uint? ClassCRC => 0x639A643E;
	}
}

