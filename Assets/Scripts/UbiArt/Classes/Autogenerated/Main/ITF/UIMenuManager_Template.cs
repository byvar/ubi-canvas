using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class UIMenuManager_Template : TemplateObj {
		[Serialize("menuInfos"                       )] public CList<UIMenuManager_Template.MenuInfo> menuInfos;
		[Serialize("useRemoteUI"                     )] public bool useRemoteUI;
		[Serialize("defaultValidInput"               )] public StringID defaultValidInput;
		[Serialize("defaultActionInput"              )] public StringID defaultActionInput;
		[Serialize("defaultBackInput"                )] public StringID defaultBackInput;
		[Serialize("menuSounds"                      )] public Placeholder menuSounds;
		[Serialize("showESRBMenu"                    )] public int showESRBMenu;
		[Serialize("defaultBackInputSecondary"       )] public StringID defaultBackInputSecondary;
		[Serialize("defaultLeftButtonInput"          )] public StringID defaultLeftButtonInput;
		[Serialize("defaultRightButtonInput"         )] public StringID defaultRightButtonInput;
		[Serialize("defaultOtherButtonInput"         )] public StringID defaultOtherButtonInput;
		[Serialize("initialInputDelay"               )] public float initialInputDelay;
		[Serialize("inputDelayWhenActive"            )] public float inputDelayWhenActive;
		[Serialize("inputStickDeadZone"              )] public float inputStickDeadZone;
		[Serialize("minimumDepthToHideDialogBalloons")] public int minimumDepthToHideDialogBalloons;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(menuInfos));
				SerializeField(s, nameof(useRemoteUI));
				SerializeField(s, nameof(defaultValidInput));
				SerializeField(s, nameof(defaultBackInput));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(menuSounds));
				SerializeField(s, nameof(showESRBMenu));
				SerializeField(s, nameof(useRemoteUI));
				SerializeField(s, nameof(defaultValidInput));
				SerializeField(s, nameof(defaultActionInput));
				SerializeField(s, nameof(defaultBackInput));
				SerializeField(s, nameof(defaultBackInputSecondary));
				SerializeField(s, nameof(defaultLeftButtonInput));
				SerializeField(s, nameof(defaultRightButtonInput));
				SerializeField(s, nameof(defaultOtherButtonInput));
				SerializeField(s, nameof(initialInputDelay));
				SerializeField(s, nameof(inputDelayWhenActive));
				SerializeField(s, nameof(inputStickDeadZone));
				SerializeField(s, nameof(minimumDepthToHideDialogBalloons));
			} else {
				SerializeField(s, nameof(menuInfos));
				SerializeField(s, nameof(useRemoteUI));
				SerializeField(s, nameof(defaultValidInput));
				SerializeField(s, nameof(defaultActionInput));
				SerializeField(s, nameof(defaultBackInput));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class MenuInfo : CSerializable {
			[Serialize("path"        )] public Path path;
			[Serialize("optionalPath")] public PathRef optionalPath;
			[Serialize("depth"       )] public int depth;
			[Serialize("flags"       )] public uint flags;
			[Serialize("Path__0"     )] public Path Path__0;
			[Serialize("int__1"      )] public int int__1;
			[Serialize("uint__2"     )] public uint uint__2;
			[Serialize("bool__3"     )] public bool bool__3;
			[Serialize("Path__4"     )] public Path Path__4;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (Settings.s.game == Settings.Game.VH) {
					SerializeField(s, nameof(Path__0));
					SerializeField(s, nameof(int__1));
					SerializeField(s, nameof(uint__2));
					SerializeField(s, nameof(bool__3));
					SerializeField(s, nameof(Path__4));
				} else {
					SerializeField(s, nameof(path));
					SerializeField(s, nameof(optionalPath));
					SerializeField(s, nameof(depth));
					SerializeField(s, nameof(flags));
				}
			}
		}
		public override uint? ClassCRC => 0x8D4F5267;
	}
}

