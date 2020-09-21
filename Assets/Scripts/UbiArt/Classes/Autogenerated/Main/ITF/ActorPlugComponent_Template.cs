using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class ActorPlugComponent_Template : ActorComponent_Template {
		public CArrayO<Generic<ActorPlugBaseController_Template>> controllers;
		public StringID unpluggedControllerID;
		public WithAnimStateMachine_Template stateMachine;
		public ActorPlugInterface_Parameters plugInterfaceParameters;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				unpluggedControllerID = s.SerializeObject<StringID>(unpluggedControllerID, name: "unpluggedControllerID");
			} else {
				controllers = s.SerializeObject<CArrayO<Generic<ActorPlugBaseController_Template>>>(controllers, name: "controllers");
				unpluggedControllerID = s.SerializeObject<StringID>(unpluggedControllerID, name: "unpluggedControllerID");
				stateMachine = s.SerializeObject<WithAnimStateMachine_Template>(stateMachine, name: "stateMachine");
				plugInterfaceParameters = s.SerializeObject<ActorPlugInterface_Parameters>(plugInterfaceParameters, name: "plugInterfaceParameters");
			}
		}
		public override uint? ClassCRC => 0x7F21C44B;
	}
}

