using UnityEngine;

namespace UbiArt.ITF {
	public partial class TutorialTextComponent_Template : ActorComponent_Template {
		[Serialize("animSize" )] public Vector2 animSize;
		[Serialize("iconPoint")] public StringID iconPoint;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animSize));
			SerializeField(s, nameof(iconPoint));
		}
		public override uint? ClassCRC => 0x170E87C7;
	}
}

