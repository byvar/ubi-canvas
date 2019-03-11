using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIMenuManager_Template : TemplateObj {
		[Serialize("menuInfos"         )] public CList<UIMenuManager_Template.MenuInfo> menuInfos;
		[Serialize("useRemoteUI"       )] public bool useRemoteUI;
		[Serialize("defaultValidInput" )] public StringID defaultValidInput;
		[Serialize("defaultActionInput")] public StringID defaultActionInput;
		[Serialize("defaultBackInput"  )] public StringID defaultBackInput;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(menuInfos));
				SerializeField(s, nameof(useRemoteUI));
				SerializeField(s, nameof(defaultValidInput));
				SerializeField(s, nameof(defaultBackInput));
			} else {
				SerializeField(s, nameof(menuInfos));
				SerializeField(s, nameof(useRemoteUI));
				SerializeField(s, nameof(defaultValidInput));
				SerializeField(s, nameof(defaultActionInput));
				SerializeField(s, nameof(defaultBackInput));
			}
		}
		public partial class MenuInfo : CSerializable {
			[Serialize("path" )] public Path path;
			[Serialize("depth")] public int depth;
			[Serialize("flags")] public uint flags;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(path));
				SerializeField(s, nameof(depth));
				SerializeField(s, nameof(flags));
			}
		}
		public override uint? ClassCRC => 0x8D4F5267;
	}
}

