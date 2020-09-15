using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class UIMenuControllers_Template : UIMenuBasic_Template {
		[Serialize("controllerLayout"    )] public CList<UIMenuControllers_Template.ControllerLayout> controllerLayout;
		[Serialize("controllerActorNames")] public CList<StringID> controllerActorNames;
		[Serialize("controllerActorPaths")] public CArray<Path> controllerActorPaths;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(controllerLayout));
				SerializeField(s, nameof(controllerActorPaths));
				SerializeField(s, nameof(controllerActorNames));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(controllerActorPaths));
				SerializeField(s, nameof(controllerActorNames));
			} else {
				SerializeField(s, nameof(controllerLayout));
				SerializeField(s, nameof(controllerActorNames));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class ControllerLayout : CSerializable {
			[Serialize("numControllers")] public uint numControllers;
			[Serialize("positions"     )] public CList<Vec2d> positions;
			[Serialize("scales"        )] public CList<Vec2d> scales;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(numControllers));
				SerializeField(s, nameof(positions));
				SerializeField(s, nameof(scales));
			}
		}
		public override uint? ClassCRC => 0xADA90AE4;
	}
}

