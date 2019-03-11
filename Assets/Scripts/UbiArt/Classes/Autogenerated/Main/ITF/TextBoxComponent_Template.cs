using UnityEngine;

namespace UbiArt.ITF {
	public partial class TextBoxComponent_Template : UIComponent_Template {
		[Serialize("styles"              )] public CList<FontTextArea.Style> styles;
		[Serialize("depthOffset"         )] public float depthOffset;
		[Serialize("preSpawnedActorPaths")] public Placeholder preSpawnedActorPaths;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(styles));
				SerializeField(s, nameof(depthOffset));
				SerializeField(s, nameof(preSpawnedActorPaths));
			} else {
				SerializeField(s, nameof(styles));
				SerializeField(s, nameof(depthOffset));
			}
		}
		public override uint? ClassCRC => 0x657ACC79;
	}
}

