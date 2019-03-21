using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class TextBoxComponent_Template : UIComponent_Template {
		[Serialize("styles"              )] public CList<FontTextArea.Style> styles;
		[Serialize("depthOffset"         )] public float depthOffset;
		[Serialize("preSpawnedActorPaths")] public CList<Path> preSpawnedActorPaths;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
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

