using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_CinematicDialogsUI_Template : CSerializable {
		[Serialize("dialogBackgroundTexturePath")] public Path dialogBackgroundTexturePath;
		[Serialize("nameBackgroundTexturePath"  )] public Path nameBackgroundTexturePath;
		[Serialize("dialogBackgroundTexture"    )] public Placeholder dialogBackgroundTexture;
		[Serialize("nameBackgroundTexture"      )] public Placeholder nameBackgroundTexture;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(dialogBackgroundTexturePath));
				SerializeField(s, nameof(nameBackgroundTexturePath));
			}
			SerializeField(s, nameof(dialogBackgroundTexture));
			SerializeField(s, nameof(nameBackgroundTexture));
		}
		public override uint? ClassCRC => 0x29C67378;
	}
}

