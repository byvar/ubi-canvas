using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class UIMenuControllers_Template : UIMenuBasic_Template {
		public CList<UIMenuControllers_Template.ControllerLayout> controllerLayout;
		public CList<StringID> controllerActorNames;
		public CArray<Path> controllerActorPaths;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				controllerLayout = s.SerializeObject<CList<UIMenuControllers_Template.ControllerLayout>>(controllerLayout, name: "controllerLayout");
				controllerActorPaths = s.SerializeObject<CArray<Path>>(controllerActorPaths, name: "controllerActorPaths");
				controllerActorNames = s.SerializeObject<CList<StringID>>(controllerActorNames, name: "controllerActorNames");
			} else if (Settings.s.game == Settings.Game.COL) {
				controllerActorPaths = s.SerializeObject<CArray<Path>>(controllerActorPaths, name: "controllerActorPaths");
				controllerActorNames = s.SerializeObject<CList<StringID>>(controllerActorNames, name: "controllerActorNames");
			} else {
				controllerLayout = s.SerializeObject<CList<UIMenuControllers_Template.ControllerLayout>>(controllerLayout, name: "controllerLayout");
				controllerActorNames = s.SerializeObject<CList<StringID>>(controllerActorNames, name: "controllerActorNames");
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class ControllerLayout : CSerializable {
			public uint numControllers;
			public CList<Vec2d> positions;
			public CList<Vec2d> scales;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				numControllers = s.Serialize<uint>(numControllers, name: "numControllers");
				positions = s.SerializeObject<CList<Vec2d>>(positions, name: "positions");
				scales = s.SerializeObject<CList<Vec2d>>(scales, name: "scales");
			}
		}
		public override uint? ClassCRC => 0xADA90AE4;
	}
}

