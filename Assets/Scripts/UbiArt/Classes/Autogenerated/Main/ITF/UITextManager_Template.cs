using UnityEngine;

namespace UbiArt.ITF {
	public partial class UITextManager_Template : TemplateObj {
		[Serialize("actorIcons" )] public CList<UITextManager_Template.ActorIcon> actorIcons;
		[Serialize("iconSize"   )] public float iconSize;
		[Serialize("iconYOffset")] public float iconYOffset;
		[Serialize("iconXOffset")] public float iconXOffset;
		[Serialize("buttonPath" )] public Path buttonPath;
		[Serialize("buttonNames")] public Placeholder buttonNames;
		[Serialize("gpePath"    )] public Path gpePath;
		[Serialize("gpeNames"   )] public Placeholder gpeNames;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(iconSize));
				SerializeField(s, nameof(iconYOffset));
				SerializeField(s, nameof(iconXOffset));
				SerializeField(s, nameof(buttonPath));
				SerializeField(s, nameof(buttonNames));
				SerializeField(s, nameof(gpePath));
				SerializeField(s, nameof(gpeNames));
			} else {
				SerializeField(s, nameof(actorIcons));
			}
		}
		public partial class ActorIcon : CSerializable {
			[Serialize("iconName")] public StringID iconName;
			[Serialize("iconPath")] public Path iconPath;
			[Serialize("fontSize")] public float fontSize;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(iconName));
				SerializeField(s, nameof(iconPath));
				SerializeField(s, nameof(fontSize));
			}
		}
		public override uint? ClassCRC => 0xAA368C44;
	}
}

