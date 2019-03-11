using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIMenuControllers_Template : UIMenuBasic_Template {
		[Serialize("controllerLayout"    )] public CList<UIMenuControllers_Template.ControllerLayout> controllerLayout;
		[Serialize("controllerActorNames")] public CList<StringID> controllerActorNames;
		[Serialize("controllerActorPaths")] public Placeholder controllerActorPaths;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(controllerLayout));
				SerializeField(s, nameof(controllerActorPaths));
				SerializeField(s, nameof(controllerActorNames));
			} else {
				SerializeField(s, nameof(controllerLayout));
				SerializeField(s, nameof(controllerActorNames));
			}
		}
		public partial class ControllerLayout : CSerializable {
			[Serialize("numControllers")] public uint numControllers;
			[Serialize("positions"     )] public CList<Vector2> positions;
			[Serialize("scales"        )] public CList<Vector2> scales;
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

