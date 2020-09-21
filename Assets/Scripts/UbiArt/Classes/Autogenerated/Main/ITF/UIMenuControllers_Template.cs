using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class UIMenuControllers_Template : UIMenuBasic_Template {
		public CListO<UIMenuControllers_Template.ControllerLayout> controllerLayout;
		public CListO<StringID> controllerActorNames;
		public CArrayO<Path> controllerActorPaths;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				controllerLayout = s.SerializeObject<CListO<UIMenuControllers_Template.ControllerLayout>>(controllerLayout, name: "controllerLayout");
				controllerActorPaths = s.SerializeObject<CArrayO<Path>>(controllerActorPaths, name: "controllerActorPaths");
				controllerActorNames = s.SerializeObject<CListO<StringID>>(controllerActorNames, name: "controllerActorNames");
			} else if (Settings.s.game == Settings.Game.COL) {
				controllerActorPaths = s.SerializeObject<CArrayO<Path>>(controllerActorPaths, name: "controllerActorPaths");
				controllerActorNames = s.SerializeObject<CListO<StringID>>(controllerActorNames, name: "controllerActorNames");
			} else {
				controllerLayout = s.SerializeObject<CListO<UIMenuControllers_Template.ControllerLayout>>(controllerLayout, name: "controllerLayout");
				controllerActorNames = s.SerializeObject<CListO<StringID>>(controllerActorNames, name: "controllerActorNames");
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class ControllerLayout : CSerializable {
			public uint numControllers;
			public CListO<Vec2d> positions;
			public CListO<Vec2d> scales;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				numControllers = s.Serialize<uint>(numControllers, name: "numControllers");
				positions = s.SerializeObject<CListO<Vec2d>>(positions, name: "positions");
				scales = s.SerializeObject<CListO<Vec2d>>(scales, name: "scales");
			}
		}
		public override uint? ClassCRC => 0xADA90AE4;
	}
}

